
using System.ServiceModel;
using KMA.Sharp2019.Notes.MoreThanNotes.DBModels;
using KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.NotesWcfServiceReference;

namespace KMA.Sharp2019.Notes.MoreThanNotes.NotesSimulator.Managers
{
    static class ConnectionManager
    {
        public static User GetUserByLogin(string login)
        {
            using (var myChannelFactory = new ChannelFactory<INotesService>("BasicHttpBinding_INotesService"))
            {
                INotesService client = myChannelFactory.CreateChannel();
                return client.GetUserByLogin(login);
            }
        }

        public static bool AddUser(User user)
        {
            using (var myChannelFactory = new ChannelFactory<INotesService>("BasicHttpBinding_INotesService"))
            {
                INotesService client = myChannelFactory.CreateChannel();
                return client.AddNewUser(user);
            }
        }
    }
}
