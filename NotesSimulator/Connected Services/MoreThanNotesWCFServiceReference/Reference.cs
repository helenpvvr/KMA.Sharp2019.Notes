﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NotesSimulator.MoreThanNotesWCFServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MoreThanNotesWCFServiceReference.INotesService")]
    public interface INotesService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/DoWork", ReplyAction="http://tempuri.org/INotesService/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/DoWork", ReplyAction="http://tempuri.org/INotesService/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INotesServiceChannel : NotesSimulator.MoreThanNotesWCFServiceReference.INotesService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NotesServiceClient : System.ServiceModel.ClientBase<NotesSimulator.MoreThanNotesWCFServiceReference.INotesService>, NotesSimulator.MoreThanNotesWCFServiceReference.INotesService {
        
        public NotesServiceClient() {
        }
        
        public NotesServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NotesServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NotesServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NotesServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
    }
}
