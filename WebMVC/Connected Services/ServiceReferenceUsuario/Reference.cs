﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebMVC.ServiceReferenceUsuario {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Result", Namespace="http://schemas.datacontract.org/2004/07/SLWCF")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ML.Usuario))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ML.Direccion))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ML.Colonia))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ML.Municipio))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ML.Estado))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ML.Pais))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ML.Rol))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Exception))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(object[]))]
    public partial class Result : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CorrectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Exception ExField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object ObjectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object[] ObjectsField;
        
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
        public bool Correct {
            get {
                return this.CorrectField;
            }
            set {
                if ((this.CorrectField.Equals(value) != true)) {
                    this.CorrectField = value;
                    this.RaisePropertyChanged("Correct");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Exception Ex {
            get {
                return this.ExField;
            }
            set {
                if ((object.ReferenceEquals(this.ExField, value) != true)) {
                    this.ExField = value;
                    this.RaisePropertyChanged("Ex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Object {
            get {
                return this.ObjectField;
            }
            set {
                if ((object.ReferenceEquals(this.ObjectField, value) != true)) {
                    this.ObjectField = value;
                    this.RaisePropertyChanged("Object");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object[] Objects {
            get {
                return this.ObjectsField;
            }
            set {
                if ((object.ReferenceEquals(this.ObjectsField, value) != true)) {
                    this.ObjectsField = value;
                    this.RaisePropertyChanged("Objects");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceUsuario.IServiceUsuario")]
    public interface IServiceUsuario {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUsuario/Add", ReplyAction="http://tempuri.org/IServiceUsuario/AddResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Municipio))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Estado))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Pais))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Rol))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(WebMVC.ServiceReferenceUsuario.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Direccion))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Colonia))]
        WebMVC.ServiceReferenceUsuario.Result Add(ML.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUsuario/Add", ReplyAction="http://tempuri.org/IServiceUsuario/AddResponse")]
        System.Threading.Tasks.Task<WebMVC.ServiceReferenceUsuario.Result> AddAsync(ML.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUsuario/Update", ReplyAction="http://tempuri.org/IServiceUsuario/UpdateResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Municipio))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Estado))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Pais))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Rol))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(WebMVC.ServiceReferenceUsuario.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Direccion))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Colonia))]
        WebMVC.ServiceReferenceUsuario.Result Update(ML.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUsuario/Update", ReplyAction="http://tempuri.org/IServiceUsuario/UpdateResponse")]
        System.Threading.Tasks.Task<WebMVC.ServiceReferenceUsuario.Result> UpdateAsync(ML.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUsuario/Delete", ReplyAction="http://tempuri.org/IServiceUsuario/DeleteResponse")]
        WebMVC.ServiceReferenceUsuario.Result Delete(int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUsuario/Delete", ReplyAction="http://tempuri.org/IServiceUsuario/DeleteResponse")]
        System.Threading.Tasks.Task<WebMVC.ServiceReferenceUsuario.Result> DeleteAsync(int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUsuario/GetAll", ReplyAction="http://tempuri.org/IServiceUsuario/GetAllResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Municipio))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Estado))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Pais))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Rol))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(WebMVC.ServiceReferenceUsuario.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Direccion))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ML.Colonia))]
        WebMVC.ServiceReferenceUsuario.Result GetAll(ML.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUsuario/GetAll", ReplyAction="http://tempuri.org/IServiceUsuario/GetAllResponse")]
        System.Threading.Tasks.Task<WebMVC.ServiceReferenceUsuario.Result> GetAllAsync(ML.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUsuario/GetById", ReplyAction="http://tempuri.org/IServiceUsuario/GetByIdResponse")]
        WebMVC.ServiceReferenceUsuario.Result GetById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUsuario/GetById", ReplyAction="http://tempuri.org/IServiceUsuario/GetByIdResponse")]
        System.Threading.Tasks.Task<WebMVC.ServiceReferenceUsuario.Result> GetByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUsuario/CambiarStatus", ReplyAction="http://tempuri.org/IServiceUsuario/CambiarStatusResponse")]
        WebMVC.ServiceReferenceUsuario.Result CambiarStatus(int idUsuario, bool status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUsuario/CambiarStatus", ReplyAction="http://tempuri.org/IServiceUsuario/CambiarStatusResponse")]
        System.Threading.Tasks.Task<WebMVC.ServiceReferenceUsuario.Result> CambiarStatusAsync(int idUsuario, bool status);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceUsuarioChannel : WebMVC.ServiceReferenceUsuario.IServiceUsuario, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceUsuarioClient : System.ServiceModel.ClientBase<WebMVC.ServiceReferenceUsuario.IServiceUsuario>, WebMVC.ServiceReferenceUsuario.IServiceUsuario {
        
        public ServiceUsuarioClient() {
        }
        
        public ServiceUsuarioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceUsuarioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceUsuarioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceUsuarioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebMVC.ServiceReferenceUsuario.Result Add(ML.Usuario usuario) {
            return base.Channel.Add(usuario);
        }
        
        public System.Threading.Tasks.Task<WebMVC.ServiceReferenceUsuario.Result> AddAsync(ML.Usuario usuario) {
            return base.Channel.AddAsync(usuario);
        }
        
        public WebMVC.ServiceReferenceUsuario.Result Update(ML.Usuario usuario) {
            return base.Channel.Update(usuario);
        }
        
        public System.Threading.Tasks.Task<WebMVC.ServiceReferenceUsuario.Result> UpdateAsync(ML.Usuario usuario) {
            return base.Channel.UpdateAsync(usuario);
        }
        
        public WebMVC.ServiceReferenceUsuario.Result Delete(int idUsuario) {
            return base.Channel.Delete(idUsuario);
        }
        
        public System.Threading.Tasks.Task<WebMVC.ServiceReferenceUsuario.Result> DeleteAsync(int idUsuario) {
            return base.Channel.DeleteAsync(idUsuario);
        }
        
        public WebMVC.ServiceReferenceUsuario.Result GetAll(ML.Usuario usuario) {
            return base.Channel.GetAll(usuario);
        }
        
        public System.Threading.Tasks.Task<WebMVC.ServiceReferenceUsuario.Result> GetAllAsync(ML.Usuario usuario) {
            return base.Channel.GetAllAsync(usuario);
        }
        
        public WebMVC.ServiceReferenceUsuario.Result GetById(int id) {
            return base.Channel.GetById(id);
        }
        
        public System.Threading.Tasks.Task<WebMVC.ServiceReferenceUsuario.Result> GetByIdAsync(int id) {
            return base.Channel.GetByIdAsync(id);
        }
        
        public WebMVC.ServiceReferenceUsuario.Result CambiarStatus(int idUsuario, bool status) {
            return base.Channel.CambiarStatus(idUsuario, status);
        }
        
        public System.Threading.Tasks.Task<WebMVC.ServiceReferenceUsuario.Result> CambiarStatusAsync(int idUsuario, bool status) {
            return base.Channel.CambiarStatusAsync(idUsuario, status);
        }
    }
}
