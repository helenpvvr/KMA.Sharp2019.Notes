using System;
using KMA.Sharp2019.Notes.MoreThanNotes.DBAdapter;
using KMA.Sharp2019.Notes.MoreThanNotes.DBModels;
using KMA.Sharp2019.Notes.MoreThanNotes.Providers;
using KMA.Sharp2019.Notes.MoreThanNotes.ProviderTools;
using KMA.Sharp2019.Notes.MoreThanNotes.Tools;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesWcfService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "NotesService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы NotesService.svc или NotesService.svc.cs в обозревателе решений и начните отладку.
    public class NotesService : INotesService
    {
        public string DoWork()
        {
            return "I WORK";
        }

        public User GetUserByLogin(string login, string password)
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

            if (user == null) return null;
            return (user.CheckPassword(password)) ? user : null;
         
           
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
