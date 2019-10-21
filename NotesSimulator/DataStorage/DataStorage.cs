using KMA.Sharp2019.Notes.MoreThanNotes.Models;
using System.Collections.Generic;
using System.Linq;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.DataStorage
{
    internal class DataStorage : IDataStorage
    {
        private readonly List<User> _users;

        internal DataStorage()
        {
            _users = new List<User>();
        }

        public bool UserExists(string login)
        {
            return _users.Exists(u => u.Login == login);
        }

        public User GetUserByLogin(string login)
        {
            return _users.FirstOrDefault(u => u.Login == login);
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public List<User> UsersList
        {
            get { return _users.ToList(); }
        }
    }
}
