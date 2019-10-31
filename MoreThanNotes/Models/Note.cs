using System;

namespace KMA.Sharp2019.Notes.MoreThanNotes.MoreThanNotes.Models
{
    class Note
    {
        #region Fields
        private Guid _guid;
        private string _name;
        private string _text;
        private DateTime? _createdDateTime;
        private DateTime? _editedDateTime;
        #endregion

        #region Properties
        public Guid Guid { get => _guid; set => _guid = value; }
        public string Name { get => _name; set => _name = value; }
        public string Text { get => _text; set => _text = value; }
        public DateTime? CreatedDateTime { get => _createdDateTime; set => _createdDateTime = value; }
        public DateTime? EditedDateTime { get => _editedDateTime; set => _editedDateTime = value; }
        #endregion

        #region Constructor
        public Note(string name, string text, DateTime? createdDateTime)
        {
            Name = name;
            Text = text;
            CreatedDateTime = createdDateTime;
            EditedDateTime = createdDateTime;
        }
        #endregion
    }
}
