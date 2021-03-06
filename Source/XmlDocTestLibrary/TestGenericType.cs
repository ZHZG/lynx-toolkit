﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestGenericType.cs" company="Lynx Toolkit">
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
//   Represents a generic test class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XmlDocTestLibrary
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents a generic test class.
    /// </summary>
    /// <typeparam name="T">The type.</typeparam>
    public class TestGenericType<T>
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public T Value { get; set; }

        /// <summary>
        /// Gets or sets the value array.
        /// </summary>
        /// <value>The value array.</value>
        public T[] ValueArray { get; set; }

        /// <summary>
        /// Gets or sets the values of type <typeparamref name="T"/>.
        /// </summary>
        /// <value>The values.</value>
        public List<T> Values { get; set; }

        /// <summary>
        /// Method8s the specified numbers.
        /// </summary>
        /// <typeparam name="T1">The type of the numbers.</typeparam>
        /// <param name="numbers">The numbers.</param>
        /// <returns>
        /// A <see cref="List{T}"/> of <typeparamref name="T1"/> numbers.
        /// </returns>
        public List<T1> Method8<T1>(List<T1> numbers)
        {
            return null;
        }
    }
}