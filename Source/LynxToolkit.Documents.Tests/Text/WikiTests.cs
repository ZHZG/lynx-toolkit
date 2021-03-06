﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WikiTests.cs" company="Lynx Toolkit">
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
// <summary>
//   Tests parsing from and formatting to OWiki.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace LynxToolkit.Documents.Tests
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Text.RegularExpressions;

    using NUnit.Framework;

    [TestFixture]
    public class WikiTests
    {
        /// <summary>
        /// Tests parsing from and formatting to OWiki.
        /// </summary>
        [Test]
        public void ParseAndFormatOWiki()
        {
            // Parse from OWiki
            var doc = ParseInputDocument();

            // Format to OWiki
            var output = OWikiFormatter.Format(doc);

            // Assert
            var expected = File.ReadAllText(@"ExpectedOutput\Example.wiki");
            CompareLines(expected, output, "OWiki to Html");
        }

        /// <summary>
        /// Tests formatting to and parsing from XHtml.
        /// </summary>
        [Test]
        public void FormatAndParseHtml()
        {
            var doc = ParseInputDocument();

            // Convert to Html
            var output = HtmlFormatter.Format(doc, "Example.html");
            var expected = File.ReadAllText(@"ExpectedOutput\Example.html");
            CompareLines(expected, output, "HtmlFormatter");

            // Parse Html
            var doc2 = HtmlParser.Parse(output);

            // Assert
            var output1 = OWikiFormatter.Format(doc);
            var output2 = OWikiFormatter.Format(doc2);
            CompareLines(output1, output2, "OWikiParser and HtmlParser");
        }

        /// <summary>
        /// Tests formatting to and parsing from Markdown.
        /// </summary>
        [Test]
        public void FormatAndParseMarkdown()
        {
            var doc = ParseInputDocument();

            // Format Markdown
            var output = MarkdownFormatter.Format(doc);
            var expected = File.ReadAllText(@"ExpectedOutput\Example.md");
            CompareLines(expected, output, "MarkdownFormatter");

            // And convert back to OWiki
            var doc2 = MarkdownParser.Parse(output, null);
            var output1 = OWikiFormatter.Format(doc);
            var output2 = OWikiFormatter.Format(doc2);
            CompareLines(output1, output2, "MarkdownParser");
        }

        /// <summary>
        /// Tests formatting to and parsing from Creole.
        /// </summary>
        [Test]
        public void FormatAndParseCreole()
        {
            var doc = WikiParser1.ParseFile(@"Input\Example.wiki");
            var output = CreoleFormatter.Format(doc);
            var expected = File.ReadAllText(@"ExpectedOutput\Example.creole");
            CompareLines(expected, output, "CreoleFormatter");

            // And convert back to OWiki
            var output1 = OWikiFormatter.Format(doc);
            var doc2 = CreoleParser.Parse(output, "Input");
            var output2 = OWikiFormatter.Format(doc2);
            CompareLines(output1, output2, "CreoleParser");
        }

        /// <summary>
        /// Tests performance.
        /// </summary>
        [Test]
        public void Performance()
        {
            var input = File.ReadAllText(@"Input\Example.wiki");
            var r1 = new Regex(@"(?:lorem|ipsum)", RegexOptions.Compiled);
            var r2 = new Regex(@"lorem", RegexOptions.Compiled);
            var r3 = new Regex(@"ipsum", RegexOptions.Compiled);
            const int N = 10000;
            int c = r1.Matches(input).Count;
            Console.WriteLine(c);
            var w1 = Stopwatch.StartNew();
            for (int i = 0; i < N; i++)
            {
                int c1 = r1.Matches(input).Count;
                if (c1 == -1)
                {
                    break;
                }
            }

            var t1 = w1.ElapsedMilliseconds;

            c = r2.Matches(input).Count + r3.Matches(input).Count;
            Console.WriteLine(c);

            var w2 = Stopwatch.StartNew();
            for (int i = 0; i < N; i++)
            {
                int c2 = r2.Matches(input).Count + r3.Matches(input).Count;
                if (c2 == -1)
                {
                    break;
                }
            }

            var t2 = w2.ElapsedMilliseconds;
            Console.WriteLine("t1:" + t1);
            Console.WriteLine("t2:" + t2);
        }

        /// <summary>
        /// Tests performances of Regex.Replace and string.Replace.
        /// </summary>
        [Test]
        public void PerformanceReplace()
        {
            var input = File.ReadAllText(@"Input\Example.wiki");
            var r1 = new Regex(@"lorem|ipsum", RegexOptions.Compiled);
            const string Replacement = "x";
            const int N = 10000;
            r1.Replace(input, string.Empty);
            var w1 = Stopwatch.StartNew();
            string result1 = null;
            for (int i = 0; i < N; i++)
            {
                result1 = r1.Replace(input, Replacement);
            }

            var t1 = w1.ElapsedMilliseconds;

            var w2 = Stopwatch.StartNew();
            string result2 = null;
            for (int i = 0; i < N; i++)
            {
                result2 = input.Replace("lorem", Replacement);
                result2 = result2.Replace("ipsum", Replacement);
            }

            Assert.AreEqual(result1, result2);
            var t2 = w2.ElapsedMilliseconds;
            Console.WriteLine("t1:" + t1);
            Console.WriteLine("t2:" + t2);
        }

        /// <summary>
        /// Compares the lines.
        /// </summary>
        /// <param name="expected">The expected.</param>
        /// <param name="actual">The actual.</param>
        /// <param name="message">The message.</param>
        private static void CompareLines(string expected, string actual, string message)
        {
            var expectedLines = expected.Split('\n');
            var actualLines = actual.Split('\n');
            for (int i = 0; i < expectedLines.Length && i < actualLines.Length; i++)
            {
                var e = expectedLines[i].Trim('\r');
                var a = actualLines[i].Trim('\r');
                Assert.AreEqual(e, a, string.Format("{0} (on line {1})", message, i + 1));
            }

            if (expectedLines.Length != actualLines.Length)
            {
                Assert.Fail("{0} (different number of lines. Expected {1}, was {2})", message, expectedLines.Length, actualLines.Length);
            }
        }

        /// <summary>
        /// Parses the input document.
        /// </summary>
        /// <returns>The document.</returns>
        private static Document ParseInputDocument()
        {
            var doc = WikiParser1.ParseFile(@"Input\Example.wiki");
            return doc;
        }
    }
}