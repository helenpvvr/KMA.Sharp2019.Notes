using System;
using System.Runtime.Serialization;

namespace KMA.Sharp2019.Notes.MoreThanNotes.DBModels
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class Note:IDBModel
    {
        #region Fields
        [DataMember]
        private Guid _guid;
        [DataMember]
        private string _title;
        [DataMember]
        private string _noteText;
        [DataMember]
        private DateTime _createdDateTime;
        [DataMember]
        private DateTime _editedDateTime;
        [DataMember]
        private Guid _userGuid;
        [DataMember]
        private User _user;
        #endregion

        #region Properties

        public Guid Guid
        {
            get { return _guid; }
            private set { _guid = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string NoteText {
            get { return _noteText; }
            set { _noteText = value; }
        }
        public DateTime CreatedDateTime
        {
            get { return _createdDateTime; }
            private set { _createdDateTime = value; }
        }
        public DateTime EditedDateTime
        {
            get { return _editedDateTime;}
            set { _editedDateTime = value; }
        }
        public Guid UserGuid
        {
            get { return _userGuid; }
            private set { _userGuid = value; }
        }
        public User User
        {
            get { return _user; }
            private set { _user = value; }
        }
        #endregion

        #region Constructor
        public Note(string title, string noteText, User user) : this()
        {
            _guid = Guid.NewGuid();
            _title = title;
            _noteText = noteText;
            _createdDateTime = DateTime.Now;
            _editedDateTime = DateTime.Now;
            _userGuid = user.Guid;
            _user = user;
            _user.Notes.Add(this);
        }

        private Note()
        {

        }
        #endregion

   
        public void DeleteDatabaseValues()
        {
            _user = null;
        }
    }
}
