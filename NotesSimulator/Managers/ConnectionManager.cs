
using System;
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

        public static bool DeleteNote(Note note)
        {
            using (var myChannelFactory = new ChannelFactory<INotesService>("BasicHttpBinding_INotesService"))
            {
                INotesService client = myChannelFactory.CreateChannel();
                return client.DeleteNotes(note);
            }
        }

        public static bool AddNote(Note note)
        {
            using (var myChannelFactory = new ChannelFactory<INotesService>("BasicHttpBinding_INotesService"))
            {
                INotesService client = myChannelFactory.CreateChannel();
                return client.AddNewNote(note);
            }
        }
        public static bool SaveNote(Note note)
        {
            using (var myChannelFactory = new ChannelFactory<INotesService>("BasicHttpBinding_INotesService"))
            {
                INotesService client = myChannelFactory.CreateChannel();
                return client.SaveNote(note);
            }
        }
        public static User GetUserByGuid(String guid)
        {
            using (var myChannelFactory = new ChannelFactory<INotesService>("BasicHttpBinding_INotesService"))
            {
                INotesService client = myChannelFactory.CreateChannel();
                return client.GetUserByGuid(Guid.Parse(guid));
                
            }
        }
    }
}
