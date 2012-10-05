﻿//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Lynx">
//     Copyright © Lynx Toolkit.
// </copyright>
//-----------------------------------------------------------------------

namespace CleanSource
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// The 'CleanSource' program.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The constructor summary substring to search for.
        /// </summary>
        private const string ConstructorSummarySubString = "/// Initializes a new instance of the";

        /// <summary>
        /// Expression to search for region/end region lines.
        /// </summary>
        private static readonly Regex RegionExpression = new Regex(@"^(\s*#(?:end)?region.*?)$", RegexOptions.Compiled | RegexOptions.Multiline | RegexOptions.Singleline);

        /// <summary>
        /// The number of files cleaned.
        /// </summary>
        private static int filesCleaned;

        /// <summary>
        /// The number of files scanned.
        /// </summary>
        private static int fileCount;

        /// <summary>
        /// Clean summaries.
        /// </summary>
        private static bool cleanSummary;

        /// <summary>
        /// Remove regions.
        /// </summary>
        private static bool cleanRegions;

        /// <summary>
        /// The executable to check out files.
        /// </summary>
        private static string openForEditExecutable;

        /// <summary>
        /// The arguments to check out files.
        /// </summary>
        private static string openForEditArguments;

        /// <summary>
        /// The main entry point of the program.
        /// </summary>
        /// <param name="args">The args.</param>
        private static void Main(string[] args)
        {
            Console.WriteLine(LynxToolkit.Application.Header);

            foreach (var arg in args)
            {
                var argx = arg.Split('=');
                switch (argx[0].ToLower())
                {
                    case "/cleansummary":
                        cleanSummary = true;
                        continue;
                    case "/cleanregions":
                        cleanRegions = true;
                        continue;
                    case "/scc":
                        if (string.Equals(argx[1], "p4", StringComparison.InvariantCultureIgnoreCase))
                        {
                            openForEditExecutable = "p4.exe";
                            openForEditArguments = "edit {0}";
                        }

                        continue;
                }

                Scan(arg);
            }

            Console.WriteLine("{0} files cleaned (of {1})", filesCleaned, fileCount);
        }

        /// <summary>
        /// Scans the specified directory.
        /// </summary>
        /// <param name="directory">The directory.</param>
        private static void Scan(string directory)
        {
            Directory.GetDirectories(directory).ToList().ForEach(Scan);
            Directory.GetFiles(directory, "*.cs").ToList().ForEach(Clean);
        }

        /// <summary>
        /// Cleans the specified file.
        /// </summary>
        /// <param name="file">The file.</param>
        private static void Clean(string file)
        {
            fileCount++;
            var input = File.ReadAllLines(file);
            var output = new StringBuilder();
            bool modified = false;

            int end;

            // Remove blank lines at end of file
            // http://stylecop.soyuz5.com/SA1518.html
            for (end = input.Length - 1; end >= 0; end--)
            {
                if (!string.IsNullOrWhiteSpace(input[end]))
                {
                    break;
                }
            }

            int start;

            // remove blank lines at start of file
            // http://stylecop.soyuz5.com/SA1517.html
            for (start = 0; start < end; start++)
            {
                if (!string.IsNullOrWhiteSpace(input[start]))
                {
                    break;
                }

                modified = true;
            }

            string previousLine = null;

            for (int i = start; i <= end; i++)
            {
                var thisline = input[i];
                var nextline = i + 1 < end ? input[i + 1] : null;

                if (cleanRegions && RegionExpression.Match(thisline).Success)
                {
                    modified = true;

                    // skip the following blank line
                    if (string.IsNullOrWhiteSpace(nextline))
                    {
                        i++;
                    }

                    continue;
                }

                // Remove duplicate lines containing "/// Initializes a new instance of the"
                if (cleanSummary && previousLine != null && previousLine.Contains(ConstructorSummarySubString) && thisline.Contains(ConstructorSummarySubString))
                {
                    modified = true;
                    continue;
                }

                // remove double blank lines
                // http://stylecop.soyuz5.com/SA1507.html
                if (string.IsNullOrWhiteSpace(thisline) && string.IsNullOrWhiteSpace(previousLine))
                {
                    continue;
                }

                // remove empty remarks comments
                if (nextline != null && Regex.IsMatch(thisline, @"^\s*///\s<remarks>\s*$") && Regex.IsMatch(nextline, @"^\s*///\s</remarks>\s*$"))
                {
                    i++;
                    continue;
                }

                if (Regex.IsMatch(thisline, @"^\s*///\s*<remarks>\s*</remarks>\s*$"))
                {
                    continue;
                }

                // trim the end
                var trimmed = thisline.TrimEnd();
                if (!string.Equals(trimmed, thisline))
                {
                    modified = true;
                }

                if (output.Length > 0)
                {
                    output.AppendLine();
                }

                output.Append(trimmed);
                previousLine = trimmed;
            }

            if (modified)
            {
                Console.WriteLine(file);
                if (openForEditExecutable != null)
                {
                    OpenForEdit(file, openForEditExecutable, openForEditArguments);
                }

                File.WriteAllText(file, output.ToString(), Encoding.UTF8);
                filesCleaned++;
            }
        }

        /// <summary>
        /// Opens the specified file for edit.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <param name="exe">The executable.</param>
        /// <param name="argumentFormatString">The argument format string.</param>
        private static void OpenForEdit(string filename, string exe, string argumentFormatString)
        {
            if (exe == null)
            {
                return;
            }

            var psi = new ProcessStartInfo(exe, string.Format(argumentFormatString, filename)) { CreateNoWindow = true, WindowStyle = ProcessWindowStyle.Hidden };
            var p = Process.Start(psi);
            p.WaitForExit();
        }
    }
}
