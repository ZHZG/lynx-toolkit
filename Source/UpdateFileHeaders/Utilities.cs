﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utilities.cs" company="Lynx">
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
//   Determines whether the specified file should be excluded.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace LynxToolkit
{
    using System;
    using System.Diagnostics;
    using System.IO;

    public static class Utilities
    {
        /// <summary>
        /// Determines whether the specified file should be excluded.
        /// </summary>
        /// <param name="excludedItems">The excluded items.</param>
        /// <param name="path">The path.</param>
        /// <returns><c>true</c> if the specified excluded items is excluded; otherwise, <c>false</c>.</returns>
        public static bool IsExcluded(string excludedItems, string path)
        {
            var name = Path.GetFileName(path);
            if (name == null)
            {
                return true;
            }

            foreach (var item in excludedItems.Split(' '))
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    continue;
                }

                if (item.StartsWith("*"))
                {
                    var pattern = item.TrimStart('*');
                    if (name.EndsWith(pattern))
                    {
                        return true;
                    }
                }

                if (item.EndsWith("*"))
                {
                    var pattern = item.TrimEnd('*');
                    if (name.StartsWith(pattern))
                    {
                        return true;
                    }
                }

                if (string.Equals(name, item, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Opens the specified file for edit.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <param name="exe">The executable.</param>
        /// <param name="argumentFormatString">The argument format string.</param>
        public static void OpenForEdit(string filename, string exe, string argumentFormatString)
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