using System.ServiceModel;
using KMA.Sharp2019.Notes.MoreThanNotes.DBModels;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesWcfService
{
    [ServiceContract]
    public interface INotesService
    {
        [OperationContract]
        string DoWork();

        [OperationContract]
        User GetUserByLogin(string login);

        [OperationContract]
        bool AddNewUser(User user);

        [OperationContract]
        string AddNewNote(Note note);

        [OperationContract]
        string DeleteNotes(Note note);

        [OperationContract]
        string SaveNote(Note note);


    }
}
