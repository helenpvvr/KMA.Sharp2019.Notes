using System;
using System.Collections.Generic;

namespace KMA.Sharp2019.Notes.MoreThanNotes.Models
{
    class User
    {
        #region Fields
        private Guid _guid;
        private string _login;
        private string _email;
        private string _password;
        private List<Note> _notes;
        #endregion

        #region Properties
        public Guid Guid
        {
            get
            {
                return _guid;
            }
            private set
            {
                _guid = value;
            }
        }
        public string Login
        {
            get
            {
                return _login;
            }
            private set
            {
                _login = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            private set
            {
                _email = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
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
            //TODO Add encription
            _password = password;
        }

        internal bool CheckPassword(string password)
        {
            //TODO Compare encrypted passwords
            return _password == password;
        }

        public override string ToString()
        {
            return Login;
        }
    }
}
