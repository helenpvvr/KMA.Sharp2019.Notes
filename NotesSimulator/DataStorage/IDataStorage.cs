using KMA.Sharp2019.Notes.MoreThanNotes.Models;
using System.Collections.Generic;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.DataStorage
{
    internal interface IDataStorage
    {
        bool UserExists(string login);

        User GetUserByLogin(string login);

        void AddUser(User user);
        List<User> UsersList { get; }
    }
}