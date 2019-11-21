using System;
using KMA.Sharp2019.Notes.MoreThanNotes.DBModels;
using KMA.Sharp2019.Notes.MoreThanNotes.Providers;
using KMA.Sharp2019.Notes.MoreThanNotes.Tools;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesWcfService
{
   public class NotesService : INotesService
    {
        public string DoWork()
        {
            return "I WORK";
        }

        public User GetUserByLogin(string login)
        {
            User user;
            try
            {
                IDBProvider dbProvider = ProviderFactory.CreateNewDBProvider();
                user = dbProvider.UserByLogin(login);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is an error: \n"+ex.Message);
                return null;
            }
            return user;
         
           
        }


        public bool AddNewUser(User user)
        {
            try
            {
                IDBProvider dbProvider = ProviderFactory.CreateNewDBProvider();
                dbProvider.AddUser(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is an error: \n" + ex.Message);
                return false;
            }
            return true;
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
