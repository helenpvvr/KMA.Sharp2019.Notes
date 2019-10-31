using System;

namespace KMA.Sharp2019.Notes.MoreThanNotes.MoreThanNotes.Models
{
    class User
    {
        #region Fields
        private Guid _guid;
        private string _login;
        private string _email;
        private string _password;
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
        #endregion

        #region Constructor

        public User(string login, string email, string password)
        {
            _guid = Guid.NewGuid();
            _login = login;
            _email = email;
            SetPassword(password);
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
