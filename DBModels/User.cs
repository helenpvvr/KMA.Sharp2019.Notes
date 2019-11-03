using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.Serialization;
using KMA.Sharp2019.Notes.MoreThanNotes.Tools;

namespace KMA.Sharp2019.Notes.MoreThanNotes.DBModels
{
    [DataContract(IsReference = true)]
    public class User
    {
        #region Fields
        [DataMember]
        private Guid _guid;
        [DataMember]
        private string _login;
        [DataMember]
        private string _email;
        [DataMember]
        private string _password;
        [DataMember]
        private List<Note> _notes;
        #endregion

        #region Properties
        public Guid Guid
        {
            get { return _guid; }
            private set { _guid = value; }
        }
        public string Login
        {
            get { return _login; }
            private set { _login = value; }
        }
        public string Email
        {
            get { return _email; }
            private set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public List<Note> Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }
        #endregion

        #region Constructor

        public User(string login, string email, string password)
        {
            _guid = Guid.NewGuid();
            _login = login;
            _email = email;
            SetPassword(password);
            _notes = new List<Note>();
        }

        public User()
        {

        }
        #endregion

        private void SetPassword(string password)
        {
            _password = Encrypting.GetMd5HashForString(password);
        }

        public bool CheckPassword(string password)
        {
            try
            {
                string res2 = Encrypting.GetMd5HashForString(password);
                return _password == res2;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public override string ToString()
        {
            return Login;
        }

        public Note GetNoteByGuid(Guid guid)
        {
            return _notes.FirstOrDefault(n => n.Guid == guid);
        }

        #region EntityConfiguration

        public class UserEntityConfiguration : EntityTypeConfiguration<User>
        {
            public UserEntityConfiguration()
            {
                ToTable("Users");
                HasKey(u => u.Guid);

                Property(u => u.Guid).HasColumnName("Guid").IsRequired();
                Property(u => u.Login).HasColumnName("Login").IsRequired();
                Property(u => u.Email).HasColumnName("Email").IsRequired();
                Property(u => u.Password).HasColumnName("Password").IsRequired();

                HasMany(u => u.Notes).WithRequired(n => n.User).HasForeignKey(n => n.UserGuid).WillCascadeOnDelete(true);
            }
        }

        #endregion
    }
}
