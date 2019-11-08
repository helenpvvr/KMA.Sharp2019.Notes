using System;
using KMA.Sharp2019.Notes.MoreThanNotes.DBModels;
using KMA.Sharp2019.Notes.MoreThanNotes.Server.NotesServerInterface;

namespace KMA.Sharp2019.Notes.MoreThanNotes.Server.NotesServerImplementation
{
    public class NotesServiceImplementation: INotesService
    {
        public string DoWork()
        {
            return "I WORK";
        }

        public String GetUserByLogin(string login, string password)
        {
            return null;
            //User user;
            //try
            //{
            //   // user = EntityWrapper.UserByLogin(login);

            //    if (user == null) return null;
            //    //return (user.CheckPassword(password)) ? user : null;
            //    return "Sucsess";
            //}
            //catch (Exception ex)
            //{

            //    return ex.Message;
            //}
        }

        public string AddNewUser(string login, string password, string email)
        {
            throw new NotImplementedException();
        }

        public string AddNewNote(Note note)
        {
            throw new NotImplementedException();
        }

        public string DeleteNotes(Note note)
        {
            throw new NotImplementedException();
        }

        public string SaveNote(Note note)
        {
            throw new NotImplementedException();
        }
    }
}
