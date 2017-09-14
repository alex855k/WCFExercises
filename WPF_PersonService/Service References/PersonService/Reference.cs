﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_PersonService.PersonService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonDTO", Namespace="http://schemas.datacontract.org/2004/07/WebServicePostPerson")]
    [System.SerializableAttribute()]
    public partial class PersonDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdresseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DistriktField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EfternavnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FornavnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PersonnrField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PostnrField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TlfnrField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int VersionField;
        
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
        public string Adresse {
            get {
                return this.AdresseField;
            }
            set {
                if ((object.ReferenceEquals(this.AdresseField, value) != true)) {
                    this.AdresseField = value;
                    this.RaisePropertyChanged("Adresse");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Distrikt {
            get {
                return this.DistriktField;
            }
            set {
                if ((object.ReferenceEquals(this.DistriktField, value) != true)) {
                    this.DistriktField = value;
                    this.RaisePropertyChanged("Distrikt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Efternavn {
            get {
                return this.EfternavnField;
            }
            set {
                if ((object.ReferenceEquals(this.EfternavnField, value) != true)) {
                    this.EfternavnField = value;
                    this.RaisePropertyChanged("Efternavn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fornavn {
            get {
                return this.FornavnField;
            }
            set {
                if ((object.ReferenceEquals(this.FornavnField, value) != true)) {
                    this.FornavnField = value;
                    this.RaisePropertyChanged("Fornavn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Personnr {
            get {
                return this.PersonnrField;
            }
            set {
                if ((this.PersonnrField.Equals(value) != true)) {
                    this.PersonnrField = value;
                    this.RaisePropertyChanged("Personnr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Postnr {
            get {
                return this.PostnrField;
            }
            set {
                if ((this.PostnrField.Equals(value) != true)) {
                    this.PostnrField = value;
                    this.RaisePropertyChanged("Postnr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tlfnr {
            get {
                return this.TlfnrField;
            }
            set {
                if ((object.ReferenceEquals(this.TlfnrField, value) != true)) {
                    this.TlfnrField = value;
                    this.RaisePropertyChanged("Tlfnr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Version {
            get {
                return this.VersionField;
            }
            set {
                if ((this.VersionField.Equals(value) != true)) {
                    this.VersionField = value;
                    this.RaisePropertyChanged("Version");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PersonService.IPersonWcfService")]
    public interface IPersonWcfService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonWcfService/GetAllePersoner", ReplyAction="http://tempuri.org/IPersonWcfService/GetAllePersonerResponse")]
        WPF_PersonService.PersonService.PersonDTO[] GetAllePersoner();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonWcfService/GetAllePersoner", ReplyAction="http://tempuri.org/IPersonWcfService/GetAllePersonerResponse")]
        System.Threading.Tasks.Task<WPF_PersonService.PersonService.PersonDTO[]> GetAllePersonerAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonWcfService/GetAllePersonerMedNavn", ReplyAction="http://tempuri.org/IPersonWcfService/GetAllePersonerMedNavnResponse")]
        WPF_PersonService.PersonService.PersonDTO[] GetAllePersonerMedNavn(string fornavn, string efternavn, bool orderEfternavnFornavn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonWcfService/GetAllePersonerMedNavn", ReplyAction="http://tempuri.org/IPersonWcfService/GetAllePersonerMedNavnResponse")]
        System.Threading.Tasks.Task<WPF_PersonService.PersonService.PersonDTO[]> GetAllePersonerMedNavnAsync(string fornavn, string efternavn, bool orderEfternavnFornavn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonWcfService/GetAllePersonerMedPostnr", ReplyAction="http://tempuri.org/IPersonWcfService/GetAllePersonerMedPostnrResponse")]
        WPF_PersonService.PersonService.PersonDTO[] GetAllePersonerMedPostnr(int fraPostnr, int tilPostnr, bool orderEfternavnFornavn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonWcfService/GetAllePersonerMedPostnr", ReplyAction="http://tempuri.org/IPersonWcfService/GetAllePersonerMedPostnrResponse")]
        System.Threading.Tasks.Task<WPF_PersonService.PersonService.PersonDTO[]> GetAllePersonerMedPostnrAsync(int fraPostnr, int tilPostnr, bool orderEfternavnFornavn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonWcfService/GetPersonMedPersonnr", ReplyAction="http://tempuri.org/IPersonWcfService/GetPersonMedPersonnrResponse")]
        WPF_PersonService.PersonService.PersonDTO GetPersonMedPersonnr(int personnr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonWcfService/GetPersonMedPersonnr", ReplyAction="http://tempuri.org/IPersonWcfService/GetPersonMedPersonnrResponse")]
        System.Threading.Tasks.Task<WPF_PersonService.PersonService.PersonDTO> GetPersonMedPersonnrAsync(int personnr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonWcfService/RetPersonData", ReplyAction="http://tempuri.org/IPersonWcfService/RetPersonDataResponse")]
        bool RetPersonData(WPF_PersonService.PersonService.PersonDTO person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonWcfService/RetPersonData", ReplyAction="http://tempuri.org/IPersonWcfService/RetPersonDataResponse")]
        System.Threading.Tasks.Task<bool> RetPersonDataAsync(WPF_PersonService.PersonService.PersonDTO person);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonWcfServiceChannel : WPF_PersonService.PersonService.IPersonWcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonWcfServiceClient : System.ServiceModel.ClientBase<WPF_PersonService.PersonService.IPersonWcfService>, WPF_PersonService.PersonService.IPersonWcfService {
        
        public PersonWcfServiceClient() {
        }
        
        public PersonWcfServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonWcfServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonWcfServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonWcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WPF_PersonService.PersonService.PersonDTO[] GetAllePersoner() {
            return base.Channel.GetAllePersoner();
        }
        
        public System.Threading.Tasks.Task<WPF_PersonService.PersonService.PersonDTO[]> GetAllePersonerAsync() {
            return base.Channel.GetAllePersonerAsync();
        }
        
        public WPF_PersonService.PersonService.PersonDTO[] GetAllePersonerMedNavn(string fornavn, string efternavn, bool orderEfternavnFornavn) {
            return base.Channel.GetAllePersonerMedNavn(fornavn, efternavn, orderEfternavnFornavn);
        }
        
        public System.Threading.Tasks.Task<WPF_PersonService.PersonService.PersonDTO[]> GetAllePersonerMedNavnAsync(string fornavn, string efternavn, bool orderEfternavnFornavn) {
            return base.Channel.GetAllePersonerMedNavnAsync(fornavn, efternavn, orderEfternavnFornavn);
        }
        
        public WPF_PersonService.PersonService.PersonDTO[] GetAllePersonerMedPostnr(int fraPostnr, int tilPostnr, bool orderEfternavnFornavn) {
            return base.Channel.GetAllePersonerMedPostnr(fraPostnr, tilPostnr, orderEfternavnFornavn);
        }
        
        public System.Threading.Tasks.Task<WPF_PersonService.PersonService.PersonDTO[]> GetAllePersonerMedPostnrAsync(int fraPostnr, int tilPostnr, bool orderEfternavnFornavn) {
            return base.Channel.GetAllePersonerMedPostnrAsync(fraPostnr, tilPostnr, orderEfternavnFornavn);
        }
        
        public WPF_PersonService.PersonService.PersonDTO GetPersonMedPersonnr(int personnr) {
            return base.Channel.GetPersonMedPersonnr(personnr);
        }
        
        public System.Threading.Tasks.Task<WPF_PersonService.PersonService.PersonDTO> GetPersonMedPersonnrAsync(int personnr) {
            return base.Channel.GetPersonMedPersonnrAsync(personnr);
        }
        
        public bool RetPersonData(WPF_PersonService.PersonService.PersonDTO person) {
            return base.Channel.RetPersonData(person);
        }
        
        public System.Threading.Tasks.Task<bool> RetPersonDataAsync(WPF_PersonService.PersonService.PersonDTO person) {
            return base.Channel.RetPersonDataAsync(person);
        }
    }
}
