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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/GetUserByLogin", ReplyAction="http://tempuri.org/INotesService/GetUserByLoginResponse")]
        KMA.Sharp2019.Notes.MoreThanNotes.DBModels.User GetUserByLogin(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/GetUserByLogin", ReplyAction="http://tempuri.org/INotesService/GetUserByLoginResponse")]
        System.Threading.Tasks.Task<KMA.Sharp2019.Notes.MoreThanNotes.DBModels.User> GetUserByLoginAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/GetUserByGuid", ReplyAction="http://tempuri.org/INotesService/GetUserByGuidResponse")]
        KMA.Sharp2019.Notes.MoreThanNotes.DBModels.User GetUserByGuid(System.Guid guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/GetUserByGuid", ReplyAction="http://tempuri.org/INotesService/GetUserByGuidResponse")]
        System.Threading.Tasks.Task<KMA.Sharp2019.Notes.MoreThanNotes.DBModels.User> GetUserByGuidAsync(System.Guid guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/AddNewUser", ReplyAction="http://tempuri.org/INotesService/AddNewUserResponse")]
        bool AddNewUser(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/AddNewUser", ReplyAction="http://tempuri.org/INotesService/AddNewUserResponse")]
        System.Threading.Tasks.Task<bool> AddNewUserAsync(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/AddNewNote", ReplyAction="http://tempuri.org/INotesService/AddNewNoteResponse")]
        bool AddNewNote(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/AddNewNote", ReplyAction="http://tempuri.org/INotesService/AddNewNoteResponse")]
        System.Threading.Tasks.Task<bool> AddNewNoteAsync(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/DeleteNotes", ReplyAction="http://tempuri.org/INotesService/DeleteNotesResponse")]
        bool DeleteNotes(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/DeleteNotes", ReplyAction="http://tempuri.org/INotesService/DeleteNotesResponse")]
        System.Threading.Tasks.Task<bool> DeleteNotesAsync(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/SaveNote", ReplyAction="http://tempuri.org/INotesService/SaveNoteResponse")]
        bool SaveNote(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/SaveNote", ReplyAction="http://tempuri.org/INotesService/SaveNoteResponse")]
        System.Threading.Tasks.Task<bool> SaveNoteAsync(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/SaveUser", ReplyAction="http://tempuri.org/INotesService/SaveUserResponse")]
        bool SaveUser(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotesService/SaveUser", ReplyAction="http://tempuri.org/INotesService/SaveUserResponse")]
        System.Threading.Tasks.Task<bool> SaveUserAsync(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.User user);
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
        
        public KMA.Sharp2019.Notes.MoreThanNotes.DBModels.User GetUserByLogin(string login) {
            return base.Channel.GetUserByLogin(login);
        }
        
        public System.Threading.Tasks.Task<KMA.Sharp2019.Notes.MoreThanNotes.DBModels.User> GetUserByLoginAsync(string login) {
            return base.Channel.GetUserByLoginAsync(login);
        }
        
        public KMA.Sharp2019.Notes.MoreThanNotes.DBModels.User GetUserByGuid(System.Guid guid) {
            return base.Channel.GetUserByGuid(guid);
        }
        
        public System.Threading.Tasks.Task<KMA.Sharp2019.Notes.MoreThanNotes.DBModels.User> GetUserByGuidAsync(System.Guid guid) {
            return base.Channel.GetUserByGuidAsync(guid);
        }
        
        public bool AddNewUser(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.User user) {
            return base.Channel.AddNewUser(user);
        }
        
        public System.Threading.Tasks.Task<bool> AddNewUserAsync(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.User user) {
            return base.Channel.AddNewUserAsync(user);
        }
        
        public bool AddNewNote(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note) {
            return base.Channel.AddNewNote(note);
        }
        
        public System.Threading.Tasks.Task<bool> AddNewNoteAsync(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note) {
            return base.Channel.AddNewNoteAsync(note);
        }
        
        public bool DeleteNotes(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note) {
            return base.Channel.DeleteNotes(note);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteNotesAsync(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note) {
            return base.Channel.DeleteNotesAsync(note);
        }
        
        public bool SaveNote(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note) {
            return base.Channel.SaveNote(note);
        }
        
        public System.Threading.Tasks.Task<bool> SaveNoteAsync(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.Note note) {
            return base.Channel.SaveNoteAsync(note);
        }
        
        public bool SaveUser(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.User user) {
            return base.Channel.SaveUser(user);
        }
        
        public System.Threading.Tasks.Task<bool> SaveUserAsync(KMA.Sharp2019.Notes.MoreThanNotes.DBModels.User user) {
            return base.Channel.SaveUserAsync(user);
        }
    }
}
