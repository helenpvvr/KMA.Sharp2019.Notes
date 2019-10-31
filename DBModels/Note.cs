using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMA.Sharp2019.Notes.MoreThanNotes.DBModels
{
    public class Note
    {
        #region Fields
        private Guid _guid;
        private string _title;
        private string _noteText;
        private readonly DateTime? _createdDateTime;
        private DateTime? _editedDateTime;
        private Guid _userGuid;
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
        public DateTime? CreatedDateTime
        {
            get { return _createdDateTime; }
        }
        public DateTime? EditedDateTime
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
        public Note(string title, string noteText, DateTime? createdDateTime)
        {
            _guid = Guid.NewGuid();
            _title = title;
            _noteText = noteText;
            _createdDateTime = createdDateTime;
            _editedDateTime = createdDateTime;
        }

        public Note() : this("", "", DateTime.Now)
        {

        }
        #endregion

        #region EntityFrameworkConfiguration
        public class NoteEntityConfiguration : EntityTypeConfiguration<Note>
        {
            public NoteEntityConfiguration()
            {
                ToTable("Notes");
                HasKey(n => n.Guid);

                Property(p => p.Guid)
                    .HasColumnName("Guid")
                    .IsRequired();
                Property(p => p.Title)
                    .HasColumnName("Title")
                    .IsRequired();
                Property(p => p.NoteText)
                    .HasColumnName("NoteText")
                    .IsRequired();
                Property(p => p.CreatedDateTime)
                    .HasColumnName("CreatedDateTime")
                    .IsRequired();
                Property(p => p.EditedDateTime)
                    .HasColumnName("EditedDateTime")
                    .IsRequired();
            }
        }
        #endregion
    }
}
