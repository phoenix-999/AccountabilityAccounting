﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccountabilityAccounting.DataProviderService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Selector", Namespace="http://schemas.datacontract.org/2004/07/DataAccessService")]
    [System.SerializableAttribute()]
    public partial class Selector : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<string, string> PredicatesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AccountabilityAccounting.DataProviderService.SelectorOptions SelectorOptionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, string> Predicates {
            get {
                return this.PredicatesField;
            }
            set {
                if ((object.ReferenceEquals(this.PredicatesField, value) != true)) {
                    this.PredicatesField = value;
                    this.RaisePropertyChanged("Predicates");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AccountabilityAccounting.DataProviderService.SelectorOptions SelectorOption {
            get {
                return this.SelectorOptionField;
            }
            set {
                if ((this.SelectorOptionField.Equals(value) != true)) {
                    this.SelectorOptionField = value;
                    this.RaisePropertyChanged("SelectorOption");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SelectorOptions", Namespace="http://schemas.datacontract.org/2004/07/DataAccessService")]
    public enum SelectorOptions : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GetSummary = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GetSign = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/AuthenticationService")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DbException", Namespace="http://schemas.datacontract.org/2004/07/AuthenticationService")]
    [System.SerializableAttribute()]
    public partial class DbException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DetailField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Detail {
            get {
                return this.DetailField;
            }
            set {
                if ((object.ReferenceEquals(this.DetailField, value) != true)) {
                    this.DetailField = value;
                    this.RaisePropertyChanged("Detail");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Updater", Namespace="http://schemas.datacontract.org/2004/07/DataAccessService")]
    [System.SerializableAttribute()]
    public partial class Updater : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AccountabilityAccounting.DataProviderService.UpdaterOptions UpdaterOptionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AccountabilityAccounting.DataProviderService.UpdaterOptions UpdaterOption {
            get {
                return this.UpdaterOptionField;
            }
            set {
                if ((this.UpdaterOptionField.Equals(value) != true)) {
                    this.UpdaterOptionField = value;
                    this.RaisePropertyChanged("UpdaterOption");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UpdaterOptions", Namespace="http://schemas.datacontract.org/2004/07/DataAccessService")]
    public enum UpdaterOptions : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UpdateSummary = 0,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataProviderService.IDataProvider")]
    public interface IDataProvider {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataProvider/GetData", ReplyAction="http://tempuri.org/IDataProvider/GetDataResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.IdentityModel.Tokens.SecurityTokenException), Action="http://tempuri.org/IDataProvider/GetDataSecurityTokenExceptionFault", Name="SecurityTokenException", Namespace="http://schemas.datacontract.org/2004/07/System.IdentityModel.Tokens")]
        [System.ServiceModel.FaultContractAttribute(typeof(AccountabilityAccounting.DataProviderService.DbException), Action="http://tempuri.org/IDataProvider/GetDataDbExceptionFault", Name="DbException", Namespace="http://schemas.datacontract.org/2004/07/AuthenticationService")]
        System.Data.DataTable GetData(AccountabilityAccounting.DataProviderService.Selector selector, AccountabilityAccounting.DataProviderService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataProvider/GetData", ReplyAction="http://tempuri.org/IDataProvider/GetDataResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetDataAsync(AccountabilityAccounting.DataProviderService.Selector selector, AccountabilityAccounting.DataProviderService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataProvider/UpdateData", ReplyAction="http://tempuri.org/IDataProvider/UpdateDataResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.IdentityModel.Tokens.SecurityTokenException), Action="http://tempuri.org/IDataProvider/UpdateDataSecurityTokenExceptionFault", Name="SecurityTokenException", Namespace="http://schemas.datacontract.org/2004/07/System.IdentityModel.Tokens")]
        [System.ServiceModel.FaultContractAttribute(typeof(AccountabilityAccounting.DataProviderService.DbException), Action="http://tempuri.org/IDataProvider/UpdateDataDbExceptionFault", Name="DbException", Namespace="http://schemas.datacontract.org/2004/07/AuthenticationService")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        void UpdateData(AccountabilityAccounting.DataProviderService.Updater updater, System.Data.DataTable table, AccountabilityAccounting.DataProviderService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataProvider/UpdateData", ReplyAction="http://tempuri.org/IDataProvider/UpdateDataResponse")]
        System.Threading.Tasks.Task UpdateDataAsync(AccountabilityAccounting.DataProviderService.Updater updater, System.Data.DataTable table, AccountabilityAccounting.DataProviderService.User user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataProviderChannel : AccountabilityAccounting.DataProviderService.IDataProvider, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataProviderClient : System.ServiceModel.ClientBase<AccountabilityAccounting.DataProviderService.IDataProvider>, AccountabilityAccounting.DataProviderService.IDataProvider {
        
        public DataProviderClient() {
        }
        
        public DataProviderClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataProviderClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataProviderClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataProviderClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable GetData(AccountabilityAccounting.DataProviderService.Selector selector, AccountabilityAccounting.DataProviderService.User user) {
            return base.Channel.GetData(selector, user);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetDataAsync(AccountabilityAccounting.DataProviderService.Selector selector, AccountabilityAccounting.DataProviderService.User user) {
            return base.Channel.GetDataAsync(selector, user);
        }
        
        public void UpdateData(AccountabilityAccounting.DataProviderService.Updater updater, System.Data.DataTable table, AccountabilityAccounting.DataProviderService.User user) {
            base.Channel.UpdateData(updater, table, user);
        }
        
        public System.Threading.Tasks.Task UpdateDataAsync(AccountabilityAccounting.DataProviderService.Updater updater, System.Data.DataTable table, AccountabilityAccounting.DataProviderService.User user) {
            return base.Channel.UpdateDataAsync(updater, table, user);
        }
    }
}
