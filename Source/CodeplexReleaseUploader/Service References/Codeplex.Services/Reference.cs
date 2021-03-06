﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Reference.cs" company="Lynx Toolkit">
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
namespace CodeplexReleaseUploader.Codeplex.Services {
    using System.Runtime.Serialization;
    using System;

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReleaseFile", Namespace="http://www.codeplex.com/services/ReleaseService/v1.0")]
    [System.SerializableAttribute()]
    public partial class ReleaseFile : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] FileDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FileNameField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FileTypeField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MimeTypeField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public byte[] FileData {
            get {
                return this.FileDataField;
            }
            set {
                if ((object.ReferenceEquals(this.FileDataField, value) != true)) {
                    this.FileDataField = value;
                    this.RaisePropertyChanged("FileData");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string FileName {
            get {
                return this.FileNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FileNameField, value) != true)) {
                    this.FileNameField = value;
                    this.RaisePropertyChanged("FileName");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string FileType {
            get {
                return this.FileTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.FileTypeField, value) != true)) {
                    this.FileTypeField = value;
                    this.RaisePropertyChanged("FileType");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string MimeType {
            get {
                return this.MimeTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.MimeTypeField, value) != true)) {
                    this.MimeTypeField = value;
                    this.RaisePropertyChanged("MimeType");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Release", Namespace="http://www.codeplex.com/services/ReleaseService/v1.0")]
    [System.SerializableAttribute()]
    public partial class Release : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private int IdField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;

        private System.Nullable<System.DateTime> ReleaseDateField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;

        private bool ShowToPublicField;

        private bool DefaultReleaseField;

        private System.Nullable<System.DateTime> ModifiedDateField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModifiedByUserNameField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DevelopmentStatusField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ChangesetIdField;

        private bool IsClickOnceReleaseField;

        private bool IsArchivedField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<System.DateTime> ReleaseDate {
            get {
                return this.ReleaseDateField;
            }
            set {
                if ((this.ReleaseDateField.Equals(value) != true)) {
                    this.ReleaseDateField = value;
                    this.RaisePropertyChanged("ReleaseDate");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public bool ShowToPublic {
            get {
                return this.ShowToPublicField;
            }
            set {
                if ((this.ShowToPublicField.Equals(value) != true)) {
                    this.ShowToPublicField = value;
                    this.RaisePropertyChanged("ShowToPublic");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public bool DefaultRelease {
            get {
                return this.DefaultReleaseField;
            }
            set {
                if ((this.DefaultReleaseField.Equals(value) != true)) {
                    this.DefaultReleaseField = value;
                    this.RaisePropertyChanged("DefaultRelease");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public System.Nullable<System.DateTime> ModifiedDate {
            get {
                return this.ModifiedDateField;
            }
            set {
                if ((this.ModifiedDateField.Equals(value) != true)) {
                    this.ModifiedDateField = value;
                    this.RaisePropertyChanged("ModifiedDate");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string ModifiedByUserName {
            get {
                return this.ModifiedByUserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ModifiedByUserNameField, value) != true)) {
                    this.ModifiedByUserNameField = value;
                    this.RaisePropertyChanged("ModifiedByUserName");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string DevelopmentStatus {
            get {
                return this.DevelopmentStatusField;
            }
            set {
                if ((object.ReferenceEquals(this.DevelopmentStatusField, value) != true)) {
                    this.DevelopmentStatusField = value;
                    this.RaisePropertyChanged("DevelopmentStatus");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string ChangesetId {
            get {
                return this.ChangesetIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ChangesetIdField, value) != true)) {
                    this.ChangesetIdField = value;
                    this.RaisePropertyChanged("ChangesetId");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=10)]
        public bool IsClickOnceRelease {
            get {
                return this.IsClickOnceReleaseField;
            }
            set {
                if ((this.IsClickOnceReleaseField.Equals(value) != true)) {
                    this.IsClickOnceReleaseField = value;
                    this.RaisePropertyChanged("IsClickOnceRelease");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=11)]
        public bool IsArchived {
            get {
                return this.IsArchivedField;
            }
            set {
                if ((this.IsArchivedField.Equals(value) != true)) {
                    this.IsArchivedField = value;
                    this.RaisePropertyChanged("IsArchived");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.codeplex.com/services/ReleaseService/v1.0", ConfigurationName="Codeplex.Services.ReleaseServiceSoap")]
    public interface ReleaseServiceSoap {

        // CODEGEN: Generating message contract since element name projectName from namespace http://www.codeplex.com/services/ReleaseService/v1.0 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.codeplex.com/services/ReleaseService/v1.0/CreateProjectRelease", ReplyAction="*")]
        CodeplexReleaseUploader.Codeplex.Services.CreateProjectReleaseResponse CreateProjectRelease(CodeplexReleaseUploader.Codeplex.Services.CreateProjectReleaseRequest request);

        // CODEGEN: Generating message contract since element name projectName from namespace http://www.codeplex.com/services/ReleaseService/v1.0 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.codeplex.com/services/ReleaseService/v1.0/CreateARelease", ReplyAction="*")]
        CodeplexReleaseUploader.Codeplex.Services.CreateAReleaseResponse CreateARelease(CodeplexReleaseUploader.Codeplex.Services.CreateAReleaseRequest request);

        // CODEGEN: Generating message contract since element name projectName from namespace http://www.codeplex.com/services/ReleaseService/v1.0 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.codeplex.com/services/ReleaseService/v1.0/CreateRelease", ReplyAction="*")]
        CodeplexReleaseUploader.Codeplex.Services.CreateReleaseResponse CreateRelease(CodeplexReleaseUploader.Codeplex.Services.CreateReleaseRequest request);

        // CODEGEN: Generating message contract since element name projectName from namespace http://www.codeplex.com/services/ReleaseService/v1.0 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.codeplex.com/services/ReleaseService/v1.0/CreateClickOnceRelease", ReplyAction="*")]
        CodeplexReleaseUploader.Codeplex.Services.CreateClickOnceReleaseResponse CreateClickOnceRelease(CodeplexReleaseUploader.Codeplex.Services.CreateClickOnceReleaseRequest request);

        // CODEGEN: Generating message contract since element name projectName from namespace http://www.codeplex.com/services/ReleaseService/v1.0 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.codeplex.com/services/ReleaseService/v1.0/UpdateRelease", ReplyAction="*")]
        CodeplexReleaseUploader.Codeplex.Services.UpdateReleaseResponse UpdateRelease(CodeplexReleaseUploader.Codeplex.Services.UpdateReleaseRequest request);

        // CODEGEN: Generating message contract since element name projectName from namespace http://www.codeplex.com/services/ReleaseService/v1.0 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.codeplex.com/services/ReleaseService/v1.0/UpdateClickOnceRelease", ReplyAction="*")]
        CodeplexReleaseUploader.Codeplex.Services.UpdateClickOnceReleaseResponse UpdateClickOnceRelease(CodeplexReleaseUploader.Codeplex.Services.UpdateClickOnceReleaseRequest request);

        // CODEGEN: Generating message contract since element name projectName from namespace http://www.codeplex.com/services/ReleaseService/v1.0 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.codeplex.com/services/ReleaseService/v1.0/UploadReleaseFiles", ReplyAction="*")]
        CodeplexReleaseUploader.Codeplex.Services.UploadReleaseFilesResponse UploadReleaseFiles(CodeplexReleaseUploader.Codeplex.Services.UploadReleaseFilesRequest request);

        // CODEGEN: Generating message contract since element name projectName from namespace http://www.codeplex.com/services/ReleaseService/v1.0 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.codeplex.com/services/ReleaseService/v1.0/UploadTheReleaseFiles", ReplyAction="*")]
        CodeplexReleaseUploader.Codeplex.Services.UploadTheReleaseFilesResponse UploadTheReleaseFiles(CodeplexReleaseUploader.Codeplex.Services.UploadTheReleaseFilesRequest request);

        // CODEGEN: Generating message contract since element name projectName from namespace http://www.codeplex.com/services/ReleaseService/v1.0 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.codeplex.com/services/ReleaseService/v1.0/GetRelease", ReplyAction="*")]
        CodeplexReleaseUploader.Codeplex.Services.GetReleaseResponse GetRelease(CodeplexReleaseUploader.Codeplex.Services.GetReleaseRequest request);
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateProjectReleaseRequest {

        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateProjectRelease", Namespace="http://www.codeplex.com/services/ReleaseService/v1.0", Order=0)]
        public CodeplexReleaseUploader.Codeplex.Services.CreateProjectReleaseRequestBody Body;

        public CreateProjectReleaseRequest() {
        }

        public CreateProjectReleaseRequest(CodeplexReleaseUploader.Codeplex.Services.CreateProjectReleaseRequestBody Body) {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ReleaseService/v1.0")]
    public partial class CreateProjectReleaseRequestBody {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string projectName;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string name;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string description;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string releaseDate;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string status;

        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public bool showToPublic;

        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public bool isDefaultRelease;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string username;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string password;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string changesetId;

        public CreateProjectReleaseRequestBody() {
        }

        public CreateProjectReleaseRequestBody(string projectName, string name, string description, string releaseDate, string status, bool showToPublic, bool isDefaultRelease, string username, string password, string changesetId) {
            this.projectName = projectName;
            this.name = name;
            this.description = description;
            this.releaseDate = releaseDate;
            this.status = status;
            this.showToPublic = showToPublic;
            this.isDefaultRelease = isDefaultRelease;
            this.username = username;
            this.password = password;
            this.changesetId = changesetId;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateProjectReleaseResponse {

        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateProjectReleaseResponse", Namespace="http://www.codeplex.com/services/ReleaseService/v1.0", Order=0)]
        public CodeplexReleaseUploader.Codeplex.Services.CreateProjectReleaseResponseBody Body;

        public CreateProjectReleaseResponse() {
        }

        public CreateProjectReleaseResponse(CodeplexReleaseUploader.Codeplex.Services.CreateProjectReleaseResponseBody Body) {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ReleaseService/v1.0")]
    public partial class CreateProjectReleaseResponseBody {

        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int CreateProjectReleaseResult;

        public CreateProjectReleaseResponseBody() {
        }

        public CreateProjectReleaseResponseBody(int CreateProjectReleaseResult) {
            this.CreateProjectReleaseResult = CreateProjectReleaseResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateAReleaseRequest {

        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateARelease", Namespace="http://www.codeplex.com/services/ReleaseService/v1.0", Order=0)]
        public CodeplexReleaseUploader.Codeplex.Services.CreateAReleaseRequestBody Body;

        public CreateAReleaseRequest() {
        }

        public CreateAReleaseRequest(CodeplexReleaseUploader.Codeplex.Services.CreateAReleaseRequestBody Body) {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ReleaseService/v1.0")]
    public partial class CreateAReleaseRequestBody {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string projectName;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string name;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string description;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string releaseDate;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string status;

        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public bool showToPublic;

        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public bool isDefaultRelease;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string username;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string password;

        public CreateAReleaseRequestBody() {
        }

        public CreateAReleaseRequestBody(string projectName, string name, string description, string releaseDate, string status, bool showToPublic, bool isDefaultRelease, string username, string password) {
            this.projectName = projectName;
            this.name = name;
            this.description = description;
            this.releaseDate = releaseDate;
            this.status = status;
            this.showToPublic = showToPublic;
            this.isDefaultRelease = isDefaultRelease;
            this.username = username;
            this.password = password;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateAReleaseResponse {

        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateAReleaseResponse", Namespace="http://www.codeplex.com/services/ReleaseService/v1.0", Order=0)]
        public CodeplexReleaseUploader.Codeplex.Services.CreateAReleaseResponseBody Body;

        public CreateAReleaseResponse() {
        }

        public CreateAReleaseResponse(CodeplexReleaseUploader.Codeplex.Services.CreateAReleaseResponseBody Body) {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ReleaseService/v1.0")]
    public partial class CreateAReleaseResponseBody {

        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int CreateAReleaseResult;

        public CreateAReleaseResponseBody() {
        }

        public CreateAReleaseResponseBody(int CreateAReleaseResult) {
            this.CreateAReleaseResult = CreateAReleaseResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateReleaseRequest {

        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateRelease", Namespace="http://www.codeplex.com/services/ReleaseService/v1.0", Order=0)]
        public CodeplexReleaseUploader.Codeplex.Services.CreateReleaseRequestBody Body;

        public CreateReleaseRequest() {
        }

        public CreateReleaseRequest(CodeplexReleaseUploader.Codeplex.Services.CreateReleaseRequestBody Body) {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ReleaseService/v1.0")]
    public partial class CreateReleaseRequestBody {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string projectName;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string name;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string description;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string releaseDate;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string status;

        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public bool showToPublic;

        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public bool showOnHomePage;

        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public bool isDefaultRelease;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string username;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string password;

        public CreateReleaseRequestBody() {
        }

        public CreateReleaseRequestBody(string projectName, string name, string description, string releaseDate, string status, bool showToPublic, bool showOnHomePage, bool isDefaultRelease, string username, string password) {
            this.projectName = projectName;
            this.name = name;
            this.description = description;
            this.releaseDate = releaseDate;
            this.status = status;
            this.showToPublic = showToPublic;
            this.showOnHomePage = showOnHomePage;
            this.isDefaultRelease = isDefaultRelease;
            this.username = username;
            this.password = password;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateReleaseResponse {

        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateReleaseResponse", Namespace="http://www.codeplex.com/services/ReleaseService/v1.0", Order=0)]
        public CodeplexReleaseUploader.Codeplex.Services.CreateReleaseResponseBody Body;

        public CreateReleaseResponse() {
        }

        public CreateReleaseResponse(CodeplexReleaseUploader.Codeplex.Services.CreateReleaseResponseBody Body) {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ReleaseService/v1.0")]
    public partial class CreateReleaseResponseBody {

        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int CreateReleaseResult;

        public CreateReleaseResponseBody() {
        }

        public CreateReleaseResponseBody(int CreateReleaseResult) {
            this.CreateReleaseResult = CreateReleaseResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateClickOnceReleaseRequest {

        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateClickOnceRelease", Namespace="http://www.codeplex.com/services/ReleaseService/v1.0", Order=0)]
        public CodeplexReleaseUploader.Codeplex.Services.CreateClickOnceReleaseRequestBody Body;

        public CreateClickOnceReleaseRequest() {
        }

        public CreateClickOnceReleaseRequest(CodeplexReleaseUploader.Codeplex.Services.CreateClickOnceReleaseRequestBody Body) {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ReleaseService/v1.0")]
    public partial class CreateClickOnceReleaseRequestBody {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string projectName;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string name;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string description;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string releaseDate;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string status;

        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public bool isDefaultRelease;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string changesetId;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public byte[] clickOnceFileBytes;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string username;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string password;

        public CreateClickOnceReleaseRequestBody() {
        }

        public CreateClickOnceReleaseRequestBody(string projectName, string name, string description, string releaseDate, string status, bool isDefaultRelease, string changesetId, byte[] clickOnceFileBytes, string username, string password) {
            this.projectName = projectName;
            this.name = name;
            this.description = description;
            this.releaseDate = releaseDate;
            this.status = status;
            this.isDefaultRelease = isDefaultRelease;
            this.changesetId = changesetId;
            this.clickOnceFileBytes = clickOnceFileBytes;
            this.username = username;
            this.password = password;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateClickOnceReleaseResponse {

        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateClickOnceReleaseResponse", Namespace="http://www.codeplex.com/services/ReleaseService/v1.0", Order=0)]
        public CodeplexReleaseUploader.Codeplex.Services.CreateClickOnceReleaseResponseBody Body;

        public CreateClickOnceReleaseResponse() {
        }

        public CreateClickOnceReleaseResponse(CodeplexReleaseUploader.Codeplex.Services.CreateClickOnceReleaseResponseBody Body) {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ReleaseService/v1.0")]
    public partial class CreateClickOnceReleaseResponseBody {

        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int CreateClickOnceReleaseResult;

        public CreateClickOnceReleaseResponseBody() {
        }

        public CreateClickOnceReleaseResponseBody(int CreateClickOnceReleaseResult) {
            this.CreateClickOnceReleaseResult = CreateClickOnceReleaseResult;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateReleaseRequest {

        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateRelease", Namespace="http://www.codeplex.com/services/ReleaseService/v1.0", Order=0)]
        public CodeplexReleaseUploader.Codeplex.Services.UpdateReleaseRequestBody Body;

        public UpdateReleaseRequest() {
        }

        public UpdateReleaseRequest(CodeplexReleaseUploader.Codeplex.Services.UpdateReleaseRequestBody Body) {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ReleaseService/v1.0")]
    public partial class UpdateReleaseRequestBody {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string projectName;

        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int releaseId;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string name;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string description;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string releaseDate;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string status;

        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public bool showToPublic;

        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public bool isDefaultRelease;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string changeSetId;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string username;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string password;

        public UpdateReleaseRequestBody() {
        }

        public UpdateReleaseRequestBody(string projectName, int releaseId, string name, string description, string releaseDate, string status, bool showToPublic, bool isDefaultRelease, string changeSetId, string username, string password) {
            this.projectName = projectName;
            this.releaseId = releaseId;
            this.name = name;
            this.description = description;
            this.releaseDate = releaseDate;
            this.status = status;
            this.showToPublic = showToPublic;
            this.isDefaultRelease = isDefaultRelease;
            this.changeSetId = changeSetId;
            this.username = username;
            this.password = password;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateReleaseResponse {

        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateReleaseResponse", Namespace="http://www.codeplex.com/services/ReleaseService/v1.0", Order=0)]
        public CodeplexReleaseUploader.Codeplex.Services.UpdateReleaseResponseBody Body;

        public UpdateReleaseResponse() {
        }

        public UpdateReleaseResponse(CodeplexReleaseUploader.Codeplex.Services.UpdateReleaseResponseBody Body) {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class UpdateReleaseResponseBody {

        public UpdateReleaseResponseBody() {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateClickOnceReleaseRequest {

        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateClickOnceRelease", Namespace="http://www.codeplex.com/services/ReleaseService/v1.0", Order=0)]
        public CodeplexReleaseUploader.Codeplex.Services.UpdateClickOnceReleaseRequestBody Body;

        public UpdateClickOnceReleaseRequest() {
        }

        public UpdateClickOnceReleaseRequest(CodeplexReleaseUploader.Codeplex.Services.UpdateClickOnceReleaseRequestBody Body) {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ReleaseService/v1.0")]
    public partial class UpdateClickOnceReleaseRequestBody {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string projectName;

        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int releaseId;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string name;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string description;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string releaseDate;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string status;

        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public bool isDefaultRelease;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string changeSetId;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public byte[] clickOnceFileBytes;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string username;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string password;

        public UpdateClickOnceReleaseRequestBody() {
        }

        public UpdateClickOnceReleaseRequestBody(string projectName, int releaseId, string name, string description, string releaseDate, string status, bool isDefaultRelease, string changeSetId, byte[] clickOnceFileBytes, string username, string password) {
            this.projectName = projectName;
            this.releaseId = releaseId;
            this.name = name;
            this.description = description;
            this.releaseDate = releaseDate;
            this.status = status;
            this.isDefaultRelease = isDefaultRelease;
            this.changeSetId = changeSetId;
            this.clickOnceFileBytes = clickOnceFileBytes;
            this.username = username;
            this.password = password;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateClickOnceReleaseResponse {

        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateClickOnceReleaseResponse", Namespace="http://www.codeplex.com/services/ReleaseService/v1.0", Order=0)]
        public CodeplexReleaseUploader.Codeplex.Services.UpdateClickOnceReleaseResponseBody Body;

        public UpdateClickOnceReleaseResponse() {
        }

        public UpdateClickOnceReleaseResponse(CodeplexReleaseUploader.Codeplex.Services.UpdateClickOnceReleaseResponseBody Body) {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class UpdateClickOnceReleaseResponseBody {

        public UpdateClickOnceReleaseResponseBody() {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadReleaseFilesRequest {

        [System.ServiceModel.MessageBodyMemberAttribute(Name="UploadReleaseFiles", Namespace="http://www.codeplex.com/services/ReleaseService/v1.0", Order=0)]
        public CodeplexReleaseUploader.Codeplex.Services.UploadReleaseFilesRequestBody Body;

        public UploadReleaseFilesRequest() {
        }

        public UploadReleaseFilesRequest(CodeplexReleaseUploader.Codeplex.Services.UploadReleaseFilesRequestBody Body) {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ReleaseService/v1.0")]
    public partial class UploadReleaseFilesRequestBody {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string projectName;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string releaseName;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public CodeplexReleaseUploader.Codeplex.Services.ReleaseFile[] files;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string username;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string password;

        public UploadReleaseFilesRequestBody() {
        }

        public UploadReleaseFilesRequestBody(string projectName, string releaseName, CodeplexReleaseUploader.Codeplex.Services.ReleaseFile[] files, string username, string password) {
            this.projectName = projectName;
            this.releaseName = releaseName;
            this.files = files;
            this.username = username;
            this.password = password;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadReleaseFilesResponse {

        [System.ServiceModel.MessageBodyMemberAttribute(Name="UploadReleaseFilesResponse", Namespace="http://www.codeplex.com/services/ReleaseService/v1.0", Order=0)]
        public CodeplexReleaseUploader.Codeplex.Services.UploadReleaseFilesResponseBody Body;

        public UploadReleaseFilesResponse() {
        }

        public UploadReleaseFilesResponse(CodeplexReleaseUploader.Codeplex.Services.UploadReleaseFilesResponseBody Body) {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class UploadReleaseFilesResponseBody {

        public UploadReleaseFilesResponseBody() {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadTheReleaseFilesRequest {

        [System.ServiceModel.MessageBodyMemberAttribute(Name="UploadTheReleaseFiles", Namespace="http://www.codeplex.com/services/ReleaseService/v1.0", Order=0)]
        public CodeplexReleaseUploader.Codeplex.Services.UploadTheReleaseFilesRequestBody Body;

        public UploadTheReleaseFilesRequest() {
        }

        public UploadTheReleaseFilesRequest(CodeplexReleaseUploader.Codeplex.Services.UploadTheReleaseFilesRequestBody Body) {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ReleaseService/v1.0")]
    public partial class UploadTheReleaseFilesRequestBody {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string projectName;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string releaseName;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public CodeplexReleaseUploader.Codeplex.Services.ReleaseFile[] files;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string recommendedFileName;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string username;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string password;

        public UploadTheReleaseFilesRequestBody() {
        }

        public UploadTheReleaseFilesRequestBody(string projectName, string releaseName, CodeplexReleaseUploader.Codeplex.Services.ReleaseFile[] files, string recommendedFileName, string username, string password) {
            this.projectName = projectName;
            this.releaseName = releaseName;
            this.files = files;
            this.recommendedFileName = recommendedFileName;
            this.username = username;
            this.password = password;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadTheReleaseFilesResponse {

        [System.ServiceModel.MessageBodyMemberAttribute(Name="UploadTheReleaseFilesResponse", Namespace="http://www.codeplex.com/services/ReleaseService/v1.0", Order=0)]
        public CodeplexReleaseUploader.Codeplex.Services.UploadTheReleaseFilesResponseBody Body;

        public UploadTheReleaseFilesResponse() {
        }

        public UploadTheReleaseFilesResponse(CodeplexReleaseUploader.Codeplex.Services.UploadTheReleaseFilesResponseBody Body) {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class UploadTheReleaseFilesResponseBody {

        public UploadTheReleaseFilesResponseBody() {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetReleaseRequest {

        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRelease", Namespace="http://www.codeplex.com/services/ReleaseService/v1.0", Order=0)]
        public CodeplexReleaseUploader.Codeplex.Services.GetReleaseRequestBody Body;

        public GetReleaseRequest() {
        }

        public GetReleaseRequest(CodeplexReleaseUploader.Codeplex.Services.GetReleaseRequestBody Body) {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ReleaseService/v1.0")]
    public partial class GetReleaseRequestBody {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string projectName;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string releaseName;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string username;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string password;

        public GetReleaseRequestBody() {
        }

        public GetReleaseRequestBody(string projectName, string releaseName, string username, string password) {
            this.projectName = projectName;
            this.releaseName = releaseName;
            this.username = username;
            this.password = password;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetReleaseResponse {

        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetReleaseResponse", Namespace="http://www.codeplex.com/services/ReleaseService/v1.0", Order=0)]
        public CodeplexReleaseUploader.Codeplex.Services.GetReleaseResponseBody Body;

        public GetReleaseResponse() {
        }

        public GetReleaseResponse(CodeplexReleaseUploader.Codeplex.Services.GetReleaseResponseBody Body) {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ReleaseService/v1.0")]
    public partial class GetReleaseResponseBody {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CodeplexReleaseUploader.Codeplex.Services.Release GetReleaseResult;

        public GetReleaseResponseBody() {
        }

        public GetReleaseResponseBody(CodeplexReleaseUploader.Codeplex.Services.Release GetReleaseResult) {
            this.GetReleaseResult = GetReleaseResult;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ReleaseServiceSoapChannel : CodeplexReleaseUploader.Codeplex.Services.ReleaseServiceSoap, System.ServiceModel.IClientChannel {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReleaseServiceSoapClient : System.ServiceModel.ClientBase<CodeplexReleaseUploader.Codeplex.Services.ReleaseServiceSoap>, CodeplexReleaseUploader.Codeplex.Services.ReleaseServiceSoap {

        public ReleaseServiceSoapClient() {
        }

        public ReleaseServiceSoapClient(string endpointConfigurationName) :
                base(endpointConfigurationName) {
        }

        public ReleaseServiceSoapClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress) {
        }

        public ReleaseServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress) {
        }

        public ReleaseServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress) {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CodeplexReleaseUploader.Codeplex.Services.CreateProjectReleaseResponse CodeplexReleaseUploader.Codeplex.Services.ReleaseServiceSoap.CreateProjectRelease(CodeplexReleaseUploader.Codeplex.Services.CreateProjectReleaseRequest request) {
            return base.Channel.CreateProjectRelease(request);
        }

        public int CreateProjectRelease(string projectName, string name, string description, string releaseDate, string status, bool showToPublic, bool isDefaultRelease, string username, string password, string changesetId) {
            CodeplexReleaseUploader.Codeplex.Services.CreateProjectReleaseRequest inValue = new CodeplexReleaseUploader.Codeplex.Services.CreateProjectReleaseRequest();
            inValue.Body = new CodeplexReleaseUploader.Codeplex.Services.CreateProjectReleaseRequestBody();
            inValue.Body.projectName = projectName;
            inValue.Body.name = name;
            inValue.Body.description = description;
            inValue.Body.releaseDate = releaseDate;
            inValue.Body.status = status;
            inValue.Body.showToPublic = showToPublic;
            inValue.Body.isDefaultRelease = isDefaultRelease;
            inValue.Body.username = username;
            inValue.Body.password = password;
            inValue.Body.changesetId = changesetId;
            CodeplexReleaseUploader.Codeplex.Services.CreateProjectReleaseResponse retVal = ((CodeplexReleaseUploader.Codeplex.Services.ReleaseServiceSoap)(this)).CreateProjectRelease(inValue);
            return retVal.Body.CreateProjectReleaseResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CodeplexReleaseUploader.Codeplex.Services.CreateAReleaseResponse CodeplexReleaseUploader.Codeplex.Services.ReleaseServiceSoap.CreateARelease(CodeplexReleaseUploader.Codeplex.Services.CreateAReleaseRequest request) {
            return base.Channel.CreateARelease(request);
        }

        public int CreateARelease(string projectName, string name, string description, string releaseDate, string status, bool showToPublic, bool isDefaultRelease, string username, string password) {
            CodeplexReleaseUploader.Codeplex.Services.CreateAReleaseRequest inValue = new CodeplexReleaseUploader.Codeplex.Services.CreateAReleaseRequest();
            inValue.Body = new CodeplexReleaseUploader.Codeplex.Services.CreateAReleaseRequestBody();
            inValue.Body.projectName = projectName;
            inValue.Body.name = name;
            inValue.Body.description = description;
            inValue.Body.releaseDate = releaseDate;
            inValue.Body.status = status;
            inValue.Body.showToPublic = showToPublic;
            inValue.Body.isDefaultRelease = isDefaultRelease;
            inValue.Body.username = username;
            inValue.Body.password = password;
            CodeplexReleaseUploader.Codeplex.Services.CreateAReleaseResponse retVal = ((CodeplexReleaseUploader.Codeplex.Services.ReleaseServiceSoap)(this)).CreateARelease(inValue);
            return retVal.Body.CreateAReleaseResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CodeplexReleaseUploader.Codeplex.Services.CreateReleaseResponse CodeplexReleaseUploader.Codeplex.Services.ReleaseServiceSoap.CreateRelease(CodeplexReleaseUploader.Codeplex.Services.CreateReleaseRequest request) {
            return base.Channel.CreateRelease(request);
        }

        public int CreateRelease(string projectName, string name, string description, string releaseDate, string status, bool showToPublic, bool showOnHomePage, bool isDefaultRelease, string username, string password) {
            CodeplexReleaseUploader.Codeplex.Services.CreateReleaseRequest inValue = new CodeplexReleaseUploader.Codeplex.Services.CreateReleaseRequest();
            inValue.Body = new CodeplexReleaseUploader.Codeplex.Services.CreateReleaseRequestBody();
            inValue.Body.projectName = projectName;
            inValue.Body.name = name;
            inValue.Body.description = description;
            inValue.Body.releaseDate = releaseDate;
            inValue.Body.status = status;
            inValue.Body.showToPublic = showToPublic;
            inValue.Body.showOnHomePage = showOnHomePage;
            inValue.Body.isDefaultRelease = isDefaultRelease;
            inValue.Body.username = username;
            inValue.Body.password = password;
            CodeplexReleaseUploader.Codeplex.Services.CreateReleaseResponse retVal = ((CodeplexReleaseUploader.Codeplex.Services.ReleaseServiceSoap)(this)).CreateRelease(inValue);
            return retVal.Body.CreateReleaseResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CodeplexReleaseUploader.Codeplex.Services.CreateClickOnceReleaseResponse CodeplexReleaseUploader.Codeplex.Services.ReleaseServiceSoap.CreateClickOnceRelease(CodeplexReleaseUploader.Codeplex.Services.CreateClickOnceReleaseRequest request) {
            return base.Channel.CreateClickOnceRelease(request);
        }

        public int CreateClickOnceRelease(string projectName, string name, string description, string releaseDate, string status, bool isDefaultRelease, string changesetId, byte[] clickOnceFileBytes, string username, string password) {
            CodeplexReleaseUploader.Codeplex.Services.CreateClickOnceReleaseRequest inValue = new CodeplexReleaseUploader.Codeplex.Services.CreateClickOnceReleaseRequest();
            inValue.Body = new CodeplexReleaseUploader.Codeplex.Services.CreateClickOnceReleaseRequestBody();
            inValue.Body.projectName = projectName;
            inValue.Body.name = name;
            inValue.Body.description = description;
            inValue.Body.releaseDate = releaseDate;
            inValue.Body.status = status;
            inValue.Body.isDefaultRelease = isDefaultRelease;
            inValue.Body.changesetId = changesetId;
            inValue.Body.clickOnceFileBytes = clickOnceFileBytes;
            inValue.Body.username = username;
            inValue.Body.password = password;
            CodeplexReleaseUploader.Codeplex.Services.CreateClickOnceReleaseResponse retVal = ((CodeplexReleaseUploader.Codeplex.Services.ReleaseServiceSoap)(this)).CreateClickOnceRelease(inValue);
            return retVal.Body.CreateClickOnceReleaseResult;
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CodeplexReleaseUploader.Codeplex.Services.UpdateReleaseResponse CodeplexReleaseUploader.Codeplex.Services.ReleaseServiceSoap.UpdateRelease(CodeplexReleaseUploader.Codeplex.Services.UpdateReleaseRequest request) {
            return base.Channel.UpdateRelease(request);
        }

        public void UpdateRelease(string projectName, int releaseId, string name, string description, string releaseDate, string status, bool showToPublic, bool isDefaultRelease, string changeSetId, string username, string password) {
            CodeplexReleaseUploader.Codeplex.Services.UpdateReleaseRequest inValue = new CodeplexReleaseUploader.Codeplex.Services.UpdateReleaseRequest();
            inValue.Body = new CodeplexReleaseUploader.Codeplex.Services.UpdateReleaseRequestBody();
            inValue.Body.projectName = projectName;
            inValue.Body.releaseId = releaseId;
            inValue.Body.name = name;
            inValue.Body.description = description;
            inValue.Body.releaseDate = releaseDate;
            inValue.Body.status = status;
            inValue.Body.showToPublic = showToPublic;
            inValue.Body.isDefaultRelease = isDefaultRelease;
            inValue.Body.changeSetId = changeSetId;
            inValue.Body.username = username;
            inValue.Body.password = password;
            CodeplexReleaseUploader.Codeplex.Services.UpdateReleaseResponse retVal = ((CodeplexReleaseUploader.Codeplex.Services.ReleaseServiceSoap)(this)).UpdateRelease(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CodeplexReleaseUploader.Codeplex.Services.UpdateClickOnceReleaseResponse CodeplexReleaseUploader.Codeplex.Services.ReleaseServiceSoap.UpdateClickOnceRelease(CodeplexReleaseUploader.Codeplex.Services.UpdateClickOnceReleaseRequest request) {
            return base.Channel.UpdateClickOnceRelease(request);
        }

        public void UpdateClickOnceRelease(string projectName, int releaseId, string name, string description, string releaseDate, string status, bool isDefaultRelease, string changeSetId, byte[] clickOnceFileBytes, string username, string password) {
            CodeplexReleaseUploader.Codeplex.Services.UpdateClickOnceReleaseRequest inValue = new CodeplexReleaseUploader.Codeplex.Services.UpdateClickOnceReleaseRequest();
            inValue.Body = new CodeplexReleaseUploader.Codeplex.Services.UpdateClickOnceReleaseRequestBody();
            inValue.Body.projectName = projectName;
            inValue.Body.releaseId = releaseId;
            inValue.Body.name = name;
            inValue.Body.description = description;
            inValue.Body.releaseDate = releaseDate;
            inValue.Body.status = status;
            inValue.Body.isDefaultRelease = isDefaultRelease;
            inValue.Body.changeSetId = changeSetId;
            inValue.Body.clickOnceFileBytes = clickOnceFileBytes;
            inValue.Body.username = username;
            inValue.Body.password = password;
            CodeplexReleaseUploader.Codeplex.Services.UpdateClickOnceReleaseResponse retVal = ((CodeplexReleaseUploader.Codeplex.Services.ReleaseServiceSoap)(this)).UpdateClickOnceRelease(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CodeplexReleaseUploader.Codeplex.Services.UploadReleaseFilesResponse CodeplexReleaseUploader.Codeplex.Services.ReleaseServiceSoap.UploadReleaseFiles(CodeplexReleaseUploader.Codeplex.Services.UploadReleaseFilesRequest request) {
            return base.Channel.UploadReleaseFiles(request);
        }

        public void UploadReleaseFiles(string projectName, string releaseName, CodeplexReleaseUploader.Codeplex.Services.ReleaseFile[] files, string username, string password) {
            CodeplexReleaseUploader.Codeplex.Services.UploadReleaseFilesRequest inValue = new CodeplexReleaseUploader.Codeplex.Services.UploadReleaseFilesRequest();
            inValue.Body = new CodeplexReleaseUploader.Codeplex.Services.UploadReleaseFilesRequestBody();
            inValue.Body.projectName = projectName;
            inValue.Body.releaseName = releaseName;
            inValue.Body.files = files;
            inValue.Body.username = username;
            inValue.Body.password = password;
            CodeplexReleaseUploader.Codeplex.Services.UploadReleaseFilesResponse retVal = ((CodeplexReleaseUploader.Codeplex.Services.ReleaseServiceSoap)(this)).UploadReleaseFiles(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CodeplexReleaseUploader.Codeplex.Services.UploadTheReleaseFilesResponse CodeplexReleaseUploader.Codeplex.Services.ReleaseServiceSoap.UploadTheReleaseFiles(CodeplexReleaseUploader.Codeplex.Services.UploadTheReleaseFilesRequest request) {
            return base.Channel.UploadTheReleaseFiles(request);
        }

        public void UploadTheReleaseFiles(string projectName, string releaseName, CodeplexReleaseUploader.Codeplex.Services.ReleaseFile[] files, string recommendedFileName, string username, string password) {
            CodeplexReleaseUploader.Codeplex.Services.UploadTheReleaseFilesRequest inValue = new CodeplexReleaseUploader.Codeplex.Services.UploadTheReleaseFilesRequest();
            inValue.Body = new CodeplexReleaseUploader.Codeplex.Services.UploadTheReleaseFilesRequestBody();
            inValue.Body.projectName = projectName;
            inValue.Body.releaseName = releaseName;
            inValue.Body.files = files;
            inValue.Body.recommendedFileName = recommendedFileName;
            inValue.Body.username = username;
            inValue.Body.password = password;
            CodeplexReleaseUploader.Codeplex.Services.UploadTheReleaseFilesResponse retVal = ((CodeplexReleaseUploader.Codeplex.Services.ReleaseServiceSoap)(this)).UploadTheReleaseFiles(inValue);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CodeplexReleaseUploader.Codeplex.Services.GetReleaseResponse CodeplexReleaseUploader.Codeplex.Services.ReleaseServiceSoap.GetRelease(CodeplexReleaseUploader.Codeplex.Services.GetReleaseRequest request) {
            return base.Channel.GetRelease(request);
        }

        public CodeplexReleaseUploader.Codeplex.Services.Release GetRelease(string projectName, string releaseName, string username, string password) {
            CodeplexReleaseUploader.Codeplex.Services.GetReleaseRequest inValue = new CodeplexReleaseUploader.Codeplex.Services.GetReleaseRequest();
            inValue.Body = new CodeplexReleaseUploader.Codeplex.Services.GetReleaseRequestBody();
            inValue.Body.projectName = projectName;
            inValue.Body.releaseName = releaseName;
            inValue.Body.username = username;
            inValue.Body.password = password;
            CodeplexReleaseUploader.Codeplex.Services.GetReleaseResponse retVal = ((CodeplexReleaseUploader.Codeplex.Services.ReleaseServiceSoap)(this)).GetRelease(inValue);
            return retVal.Body.GetReleaseResult;
        }
    }
}