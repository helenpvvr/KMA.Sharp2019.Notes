using System;
using KMA.Sharp2019.Notes.MoreThanNotes.DBModels;
using KMA.Sharp2019.Notes.MoreThanNotes.Providers;
using KMA.Sharp2019.Notes.MoreThanNotes.Tools;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesWcfService
{
   public class NotesService : INotesService
    {
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
                Console.WriteLine(@"There is an error:"+ex.Message);
                return null;
            }
            return user;
         
           
        }

        public User GetUserByGuid(Guid guid)
        {
            User user;
            try
            {
                IDBProvider dbProvider = ProviderFactory.CreateNewDBProvider();
                user = dbProvider.UserByGuid(guid);
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"There is an error:" + ex.Message);
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
                Console.WriteLine(@"There is an error:" + ex.Message);
                return false;
            }
            return true;
        }

        public bool AddNewNote(Note note)
        {
            try
            {
                IDBProvider dbProvider = ProviderFactory.CreateNewDBProvider();
                dbProvider.AddNote(note);
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"There is an error:" + ex.Message);
                return false;
            }
            return true;
        }

        public bool DeleteNotes(Note note)
        {
            try
            {
                IDBProvider dbProvider = ProviderFactory.CreateNewDBProvider();
                dbProvider.DeleteNote(note);
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"There is an error:" + ex.Message);
                return false;
            }
            return true;
        }

        public bool SaveNote(Note note)
        {
            try
            {
                IDBProvider dbProvider = ProviderFactory.CreateNewDBProvider();
                dbProvider.SaveNote(note);
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"There is an error:" + ex.Message);
                return false;
            }
            return true;
        }

        public bool SaveUser(User user)
        {
            try
            {
                IDBProvider dbProvider = ProviderFactory.CreateNewDBProvider();
                dbProvider.SaveUser(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"There is an error:" + ex.Message);
                return false;
            }

            return true;
        }
    }
}
