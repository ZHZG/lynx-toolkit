﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainViewModel.cs" company="Lynx Toolkit">
//   The MIT License (MIT)
//   
//   Copyright (c) 2012 Oystein Bjorke
//   
//   Permission is hereby granted, free of charge, to any person obtaining a
//   copy of this software and associated documentation files (the
//   "Software"), to deal in the Software without restriction, including
//   without limitation the rights to use, copy, modify, merge, publish,
//   distribute, sublicense, and/or sell copies of the Software, and to
//   permit persons to whom the Software is furnished to do so, subject to
//   the following conditions:
//   
//   The above copyright notice and this permission notice shall be included
//   in all copies or substantial portions of the Software.
//   
//   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
//   OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
//   MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
//   IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
//   CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
//   TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
//   SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace WikiPad
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Documents;
    using System.Windows.Input;

    using LynxToolkit;
    using LynxToolkit.Documents;
    using LynxToolkit.Documents.Html;

    using Microsoft.Win32;

    public class MainViewModel : Observable
    {
        private readonly CancellationTokenSource updateLoopCancellationTokenSource;

        private CancellationTokenSource currentUpdateTaskCancellationTokenSource;

        private FlowDocument flowDocument;

        private string html;

        private WikiProject project;

        private WikiDocument selectedDocument;

        private int updateFlag;

        public MainViewModel()
        {
            this.OpenProjectCommand = new DelegateCommand(this.OpenProject);
            this.SaveCommand = new DelegateCommand(
                () => this.SelectedDocument.Save(this.Project.Scc),
                () => this.SelectedDocument != null && this.SelectedDocument.IsModified);
            this.RevertCommand = new DelegateCommand(
                this.Revert, () => this.SelectedDocument != null && this.SelectedDocument.IsModified);
            this.SaveAllCommand = new DelegateCommand(
                this.SaveAll, () => this.Project != null && this.Project.Documents.Any(d => d.IsModified));
            this.ExitCommand = new DelegateCommand(this.Exit);

            this.OpenExternalEditorCommand = new DelegateCommand(this.OpenExternalEditor, () => this.SelectedDocument != null);
            this.ExploreCommand = new DelegateCommand(this.Explore, () => this.SelectedDocument != null);

            var args = Environment.GetCommandLineArgs();
            foreach (var arg in args)
            {
                if (arg.EndsWith(".wikiproj"))
                {
                    this.Open(arg);
                }
            }

            this.updateLoopCancellationTokenSource = new CancellationTokenSource();
            Task.Factory.StartNew(() => this.UpdateLoop(this.updateLoopCancellationTokenSource.Token));
        }

        public ICommand ExitCommand { get; private set; }

        public FlowDocument FlowDocument
        {
            get
            {
                return this.flowDocument;
            }

            set
            {
                this.SetValue(ref this.flowDocument, value, "FlowDocument");
            }
        }

        private Uri outputSource;

        public Uri OutputSource
        {
            get
            {
                return this.outputSource;
            }

            set
            {
                this.SetValue(ref this.outputSource, value, "OutputSource");
            }
        }

        private string errorMessage;

        public string ErrorMessage
        {
            get
            {
                return this.errorMessage;
            }

            set
            {
                this.SetValue(ref this.errorMessage, value, "ErrorMessage");
            }
        }

        public string Html
        {
            get
            {
                return this.html;
            }

            set
            {
                this.SetValue(ref this.html, value, "Html");
            }
        }

        public string Input
        {
            get
            {
                return this.SelectedDocument != null ? this.SelectedDocument.Content : null;
            }

            set
            {
                this.SelectedDocument.Content = value;
                this.Update();
            }
        }

        public ICommand OpenProjectCommand { get; private set; }
        public ICommand OpenExternalEditorCommand { get; private set; }
        public ICommand ExploreCommand { get; private set; }

        public WikiProject Project
        {
            get
            {
                return this.project;
            }

            set
            {
                this.SetValue(ref this.project, value, "Project");
            }
        }

        public ICommand RevertCommand { get; private set; }

        public ICommand SaveAllCommand { get; private set; }

        public ICommand SaveCommand { get; private set; }

        public WikiDocument SelectedDocument
        {
            get
            {
                return this.selectedDocument;
            }

            set
            {
                this.SetValue(ref this.selectedDocument, value, "SelectedDocument");
                this.OnPropertyChanged("Input");
                this.Update();
            }
        }

        public string Title
        {
            get
            {
                return this.Project != null ? string.Format("WikiPad - {0}", this.Project.FileName) : "WikiPad";
            }
        }

        public bool CanClose()
        {
            if (this.Project == null)
            {
                return true;
            }

            foreach (var doc in this.Project.Documents)
            {
                if (doc.IsModified)
                {
                    var r = MessageBox.Show(
                        "Do you want to save " + doc.FileName + "?", this.Project.FileName, MessageBoxButton.YesNoCancel);
                    if (r == MessageBoxResult.Yes)
                    {
                        doc.Save(this.Project.Scc);
                        continue;
                    }

                    if (r == MessageBoxResult.No)
                    {
                        continue;
                    }

                    return false;
                }
            }

            return true;
        }

        public void Closed()
        {
            this.updateLoopCancellationTokenSource.Cancel();
        }

        private void Exit()
        {
            if (!this.CanClose())
            {
                return;
            }

            Application.Current.Shutdown();
        }

        private void Open(string filePath)
        {
            if (!this.CanClose())
            {
                return;
            }

            try
            {
                this.Project = WikiProject.Load(filePath);
                Environment.CurrentDirectory = this.Project.Directory;
                this.OnPropertyChanged("Title");
                this.SelectedDocument = this.Project.Documents.FirstOrDefault();
            }
            catch (Exception)
            {
            }
        }

        private void OpenProject()
        {
            var d = new OpenFileDialog();
            d.Filter = "Wiki projects (*.wikiproj)|*.wikiproj";
            d.DefaultExt = ".wikiproj";
            if (d.ShowDialog().Value)
            {
                this.Open(d.FileName);
            }
        }

        private void OpenExternalEditor()
        {
            if (this.SelectedDocument != null)
            {
                Process.Start(this.SelectedDocument.FullPath);
            }
        }

        private void Explore()
        {
            if (this.SelectedDocument != null)
            {
                Process.Start("Explorer.exe", "/select," + this.SelectedDocument.FullPath);
            }
        }

        private void Revert()
        {
            this.SelectedDocument.Revert();
            this.OnPropertyChanged("Input");
            this.Update();
        }

        private void SaveAll()
        {
            if (this.Project == null)
            {
                return;
            }

            foreach (var d in this.Project.Documents)
            {
                d.Save(this.Project.Scc);
            }
        }

        private void Update()
        {
            // if (currentUpdateTaskCancellationTokenSource != null)
            // {
            // currentUpdateTaskCancellationTokenSource.Cancel();
            // }
            Interlocked.CompareExchange(ref this.updateFlag, 1, 0);
        }

        private void UpdateCore(CancellationToken cancellationToken)
        {
            this.ErrorMessage = null;
            if (this.SelectedDocument == null || this.Project == null)
            {
                this.Html = null;
                return;
            }

            var documentFolder = System.IO.Path.GetDirectoryName(this.SelectedDocument.FullPath);
            var includeDefaultExtension = System.IO.Path.GetExtension(this.SelectedDocument.FileName);
            var template = System.IO.Path.Combine(this.Project.Directory, this.Project.Template);
            var formatter = new HtmlFormatter
                              {
                                  Template = template,
                                  LocalLinkFormatString = this.Project.LocalLinks,
                                  Variables = this.Project.GetVariables(),
                                  ImageBaseDirectory = documentFolder
                              };
            try
            {
                cancellationToken.ThrowIfCancellationRequested();
                var parser = new WikiParser(this.Project.GetDefines(), this.Project.GetVariables(), File.OpenRead, documentFolder)
                                 {
                                     IncludeDefaultExtension = includeDefaultExtension
                                 };
                var doc = parser.ParseText(this.Input);

                cancellationToken.ThrowIfCancellationRequested();

                var outputPath = System.IO.Path.GetFullPath(System.IO.Path.ChangeExtension(
                    System.IO.Path.Combine(this.Project.Output, this.SelectedDocument.FileName), ".html"));

                // this.Wiki = OWikiFormatter.Format(doc);
                // this.WikiCreole = CreoleFormatter.Format(doc);
                // this.WikiMarkdown = MarkdownFormatter.Format(doc);
                // this.WikiConfluence = ConfluenceFormatter.Format(doc);
                // this.WikiCodeplex = CodeplexFormatter.Format(doc);
                Utilities.CreateDirectoryIfMissing(System.IO.Path.GetDirectoryName(outputPath));
                using (var stream = File.Create(outputPath))
                {
                    formatter.Format(doc, stream);
                }

                this.OutputSource = null;
                this.OutputSource = new Uri(outputPath, UriKind.Absolute);
            }
            catch (Exception e)
            {
                this.OutputSource = null;
                this.ErrorMessage = e.Message;
            }

            //// File.WriteAllText("temp.txt", Html, Encoding.UTF8);
            //// System.Diagnostics.Process.Start("temp.txt");
            // var doc2 = HtmlParser.ParseText(this.Html);
            // this.Wiki2 = OWikiFormatter.Format(doc2);

            //// File.WriteAllText("Index.html", Html);
            //// var docCreole = CreoleParser.ParseText(WikiCreole);
            //// var docMarkdown = MarkdownParser.ParseText(WikiCreole);
            // this.Document = XmlFormatter.Format(doc);
            // this.FlowDocument = FlowDocumentFormatter.Format(doc, "images");
            // var js = new JsonSerializer();
            // var s = new StringWriter();
            // var w = new JsonTextWriter(s);
            // w.Formatting = Formatting.Indented;
            // js.Serialize(w, doc);
            // this.DocumentJSON = s.GetStringBuilder().ToString();

            // var json = new ServiceStack.Text.JsonSerializer<Document>();
            // DocumentJSON = json.SerializeToString(doc);
        }

        private void UpdateLoop(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                if (Interlocked.CompareExchange(ref this.updateFlag, 0, 1) == 1)
                {
                    this.currentUpdateTaskCancellationTokenSource = new CancellationTokenSource();
                    this.UpdateCore(this.currentUpdateTaskCancellationTokenSource.Token);
                }

                Thread.Yield();
            }
        }
    }
}