using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using KMA.Sharp2019.Notes.MoreThanNotes.DBAdapter;
using KMA.Sharp2019.Notes.MoreThanNotes.DBModels;
using KMA.Sharp2019.Notes.MoreThanNotes.NotesWcfService;

namespace NotesWcfService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "NotesService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы NotesService.svc или NotesService.svc.cs в обозревателе решений и начните отладку.
    public class NotesService : INotesService
    {
        public string DoWork()
        {
            throw new NotImplementedException();
        }

        public User GetUserByLogin(string login, string password)
        {
            User user;
            try
            {
                user = EntityWrapper.UserByLogin(login);
                if (user == null) return null;
                return (user.CheckPassword(password)) ? user : null;

            }
            catch (Exception ex)
            {
                return null;
            }
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
