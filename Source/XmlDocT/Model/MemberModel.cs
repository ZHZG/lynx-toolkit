﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MemberModel.cs" company="Lynx Toolkit">
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
namespace XmlDocT
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public abstract class MemberModel : Model
    {
        protected MemberModel(TypeModel parent, MemberInfo info)
        {
            this.Parent = parent;
            this.Info = info;
        }

        public Type DeclaringType
        {
            get
            {
                return this.Info.DeclaringType;
            }
        }

        public MemberInfo Info { get; private set; }

        public bool IsOverloaded { get; set; }

        public string Name
        {
            get
            {
                return this.Info.Name;
            }
        }

        public TypeModel Parent { get; private set; }

        public override string GetDescription()
        {
            if (this.IsInherited() && this.Info != null)
            {
                return string.Format(
                    "{0} (Inherited from <see cref=\"T:{1}\" />.)", this.Description, this.Info.DeclaringType.FullName);
            }

            return this.Description;
        }

        public virtual IEnumerable<ParameterModel> GetParameters()
        {
            yield break;
        }

        public override IEnumerable<Type> GetRelatedTypes()
        {
            if (this.Info != null)
            {
                yield return this.Info.DeclaringType;
            }
        }

        public override bool IsInherited()
        {
            return this.Info == null || this.Info.DeclaringType != this.Parent.Type;
        }
    }
}