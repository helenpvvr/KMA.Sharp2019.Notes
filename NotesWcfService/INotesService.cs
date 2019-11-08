using System;
using System.ServiceModel;
using KMA.Sharp2019.Notes.MoreThanNotes.DBModels;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesWcfService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "INotesService" в коде и файле конфигурации.
    [ServiceContract]
    public interface INotesService
    {
        [OperationContract]
        string DoWork();

        [OperationContract]
        String GetUserByLogin(string login, string password);

        [OperationContract]
        string AddNewUser(string login, string password, string email);

        [OperationContract]
        string AddNewNote(Note note);

        [OperationContract]
        string DeleteNotes(Note note);

        [OperationContract]
        string SaveNote(Note note);


    }
}
