﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.NotesWcfServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NotesWcfServiceReference.INotesService")]
    public interface INotesService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/DoWork", ReplyAction="http://tempuri.org/INotesService/DoWorkResponse")]
        string DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/DoWork", ReplyAction="http://tempuri.org/INotesService/DoWorkResponse")]
        System.Threading.Tasks.Task<string> DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/GetUserByLogin", ReplyAction="http://tempuri.org/INotesService/GetUserByLoginResponse")]
        string GetUserByLogin(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/GetUserByLogin", ReplyAction="http://tempuri.org/INotesService/GetUserByLoginResponse")]
        System.Threading.Tasks.Task<string> GetUserByLoginAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/AddNewUser", ReplyAction="http://tempuri.org/INotesService/AddNewUserResponse")]
        string AddNewUser(string login, string password, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/AddNewUser", ReplyAction="http://tempuri.org/INotesService/AddNewUserResponse")]
        System.Threading.Tasks.Task<string> AddNewUserAsync(string login, string password, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/AddNewNote", ReplyAction="http://tempuri.org/INotesService/AddNewNoteResponse")]
        string AddNewNote(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/AddNewNote", ReplyAction="http://tempuri.org/INotesService/AddNewNoteResponse")]
        System.Threading.Tasks.Task<string> AddNewNoteAsync(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/DeleteNotes", ReplyAction="http://tempuri.org/INotesService/DeleteNotesResponse")]
        string DeleteNotes(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/DeleteNotes", ReplyAction="http://tempuri.org/INotesService/DeleteNotesResponse")]
        System.Threading.Tasks.Task<string> DeleteNotesAsync(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/SaveNote", ReplyAction="http://tempuri.org/INotesService/SaveNoteResponse")]
        string SaveNote(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/SaveNote", ReplyAction="http://tempuri.org/INotesService/SaveNoteResponse")]
        System.Threading.Tasks.Task<string> SaveNoteAsync(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INotesServiceChannel : KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.NotesWcfServiceReference.INotesService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NotesServiceClient : System.ServiceModel.ClientBase<KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.NotesWcfServiceReference.INotesService>, KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.NotesWcfServiceReference.INotesService {
        
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
        
        public string DoWork() {
            return base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task<string> DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public string GetUserByLogin(string login, string password) {
            return base.Channel.GetUserByLogin(login, password);
        }
        
        public System.Threading.Tasks.Task<string> GetUserByLoginAsync(string login, string password) {
            return base.Channel.GetUserByLoginAsync(login, password);
        }
        
        public string AddNewUser(string login, string password, string email) {
            return base.Channel.AddNewUser(login, password, email);
        }
        
        public System.Threading.Tasks.Task<string> AddNewUserAsync(string login, string password, string email) {
            return base.Channel.AddNewUserAsync(login, password, email);
        }
        
        public string AddNewNote(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note) {
            return base.Channel.AddNewNote(note);
        }
        
        public System.Threading.Tasks.Task<string> AddNewNoteAsync(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note) {
            return base.Channel.AddNewNoteAsync(note);
        }
        
        public string DeleteNotes(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note) {
            return base.Channel.DeleteNotes(note);
        }
        
        public System.Threading.Tasks.Task<string> DeleteNotesAsync(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note) {
            return base.Channel.DeleteNotesAsync(note);
        }
        
        public string SaveNote(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note) {
            return base.Channel.SaveNote(note);
        }
        
        public System.Threading.Tasks.Task<string> SaveNoteAsync(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note) {
            return base.Channel.SaveNoteAsync(note);
        }
    }
}