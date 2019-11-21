using System.ServiceModel;
using KMA.Sharp2019.Notes.MoreThanNotes.DBModels;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesWcfService
{
    [ServiceContract]
    public interface INotesService
    {
        [OperationContract]
        User GetUserByLogin(string login);

        [OperationContract]
        bool AddNewUser(User user);

        [OperationContract]
        bool AddNewNote(Note note);

        [OperationContract]
        bool DeleteNotes(Note note);

        [OperationContract]
        bool SaveNote(Note note);


    }
}
