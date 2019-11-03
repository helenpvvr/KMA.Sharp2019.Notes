using System;
using System.Data.Entity;
using System.Linq;
using KMA.Sharp2019.Notes.MoreThanNotes.DBModels;

namespace KMA.Sharp2019.Notes.MoreThanNotes.DBAdapter
{
    public static class EntityWrapper
    {
        public static bool UserExists(string login)
        {
            using (var context = new MoreThanNotesDBContext())
            {
                return context.Users.Any(u => u.Login == login);
            }
        }

        public static User UserByLogin(string login)
        {
            using (var context = new MoreThanNotesDBContext())
            {
                return context.Users.Include(u => u.Notes).FirstOrDefault(u => u.Login == login);
            }
        }

        // TODO if it needs
        public static User UserByGuid(Guid guid)
        {
            using (var context = new MoreThanNotesDBContext())
            {
                return context.Users.Include(u => u.Notes).FirstOrDefault(u => u.Guid == guid);
            }
        }

        // TODO all notes (don't need)

        public static void AddUser(User user)
        {
            using (var context = new MoreThanNotesDBContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public static void AddNote(Note note)
        {
            using (var context = new MoreThanNotesDBContext())
            {
                note.DeleteDatabaseValues();
                context.Notes.Add(note);
                context.SaveChanges();
            }
        }

        public static void SaveNote(Note note)
        {
            using (var context = new MoreThanNotesDBContext())
            {
                context.Entry(note).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public static void DeleteNote(Note note)
        {
            using (var context = new MoreThanNotesDBContext())
            {
                note.DeleteDatabaseValues();
                context.Notes.Attach(note);
                context.Notes.Remove(note);
                context.SaveChanges();
            }
        }
    }
}
