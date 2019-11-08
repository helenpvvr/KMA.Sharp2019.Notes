using System;
using KMA.Sharp2019.Notes.MoreThanNotes.DBModels;

namespace KMA.Sharp2019.Notes.MoreThanNotes.Providers
{
    public interface IDBProvider : IDisposable
    {
        bool UserExists(string login);
        User UserByLogin(string login);
        User UserByGuid(Guid guid);
        void AddUser(User user);
        void AddNote(Note note);
        void SaveNote(Note note);
        void DeleteNote(Note note);

    }
    
}
