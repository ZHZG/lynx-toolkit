﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="JsonFormatter.cs" company="Lynx Toolkit">
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
//   Implements a document formatter that serializes to JSON.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LynxToolkit.Documents
{
    using System.IO;

    /// <summary>
    /// Implements a document formatter that serializes to JSON.
    /// </summary>
    public class JsonFormatter : IDocumentFormatter
    {
        /// <summary>
        /// The JSON serializer.
        /// </summary>
        private static JsonSerializer js = new JsonSerializer();

        /// <summary>
        /// Formats the specified <see cref="Document" /> to the specified <see cref="Stream" />.
        /// </summary>
        /// <param name="doc">The input <see cref="Document" />.</param>
        /// <param name="stream">The output <see cref="Stream" />.</param>
        public void Format(Document doc, Stream stream)
        {
            using (var tw = new StreamWriter(stream))
            {
                js.Serialize(tw, doc);
            }
        }
    }
}