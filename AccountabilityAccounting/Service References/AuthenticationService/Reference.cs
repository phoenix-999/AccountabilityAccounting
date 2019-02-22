﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccountabilityAccounting.AuthenticationService {
    using System.Runtime.Serialization;
    using System;
    
    
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AuthenticationService.IAuthentication")]
    public interface IAuthentication {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthentication/Authenticate", ReplyAction="http://tempuri.org/IAuthentication/AuthenticateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.IdentityModel.Tokens.SecurityTokenException), Action="http://tempuri.org/IAuthentication/AuthenticateSecurityTokenExceptionFault", Name="SecurityTokenException", Namespace="http://schemas.datacontract.org/2004/07/System.IdentityModel.Tokens")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://tempuri.org/IAuthentication/AuthenticateExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        AccountabilityAccounting.AuthenticationService.User Authenticate(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthentication/Authenticate", ReplyAction="http://tempuri.org/IAuthentication/AuthenticateResponse")]
        System.Threading.Tasks.Task<AccountabilityAccounting.AuthenticationService.User> AuthenticateAsync(string userName, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthenticationChannel : AccountabilityAccounting.AuthenticationService.IAuthentication, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthenticationClient : System.ServiceModel.ClientBase<AccountabilityAccounting.AuthenticationService.IAuthentication>, AccountabilityAccounting.AuthenticationService.IAuthentication {
        
        public AuthenticationClient() {
        }
        
        public AuthenticationClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthenticationClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticationClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AccountabilityAccounting.AuthenticationService.User Authenticate(string userName, string password) {
            return base.Channel.Authenticate(userName, password);
        }
        
        public System.Threading.Tasks.Task<AccountabilityAccounting.AuthenticationService.User> AuthenticateAsync(string userName, string password) {
            return base.Channel.AuthenticateAsync(userName, password);
        }
    }
}
