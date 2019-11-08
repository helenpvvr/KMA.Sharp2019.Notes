using System;
using System.Data.Entity;
using System.Linq;
using KMA.Sharp2019.Notes.MoreThanNotes.DBModels;
using KMA.Sharp2019.Notes.MoreThanNotes.Providers;

namespace KMA.Sharp2019.Notes.MoreThanNotes.DBAdapter
{
    public class EntityWrapper:IDBProvider
    {
        private bool _disposed;
        private readonly MoreThanNotesDBContext _context;
        public EntityWrapper()
        {
            _context = new MoreThanNotesDBContext();
        }

        ~EntityWrapper()
        {
            Dispose(false);
        }
        public bool UserExists(string login)
        {
           return _context.Users.Any(u => u.Login == login);
        }

        public  User UserByLogin(string login)
        {
            return _context.Users.Include(u => u.Notes).FirstOrDefault(u => u.Login == login);
        
        }

        // TODO if it needs
        public  User UserByGuid(Guid guid)
        {
               return _context.Users.Include(u => u.Notes).FirstOrDefault(u => u.Guid == guid);

        }

        public  void AddUser(User user)
        {
                _context.Users.Add(user);
                _context.SaveChanges();
   
        }

        public  void AddNote(Note note)
        {
                note.DeleteDatabaseValues();
                _context.Notes.Add(note);
                _context.SaveChanges();
            
        }

        public  void SaveNote(Note note)
        {
                _context.Entry(note).State = EntityState.Modified;
                _context.SaveChanges();
        }

        public  void DeleteNote(Note note)
        {
                note.DeleteDatabaseValues();
                _context.Notes.Attach(note);
                _context.Notes.Remove(note);
                _context.SaveChanges();

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                _context?.Dispose();
            }

            // Free any unmanaged objects here.
            _disposed = true;
        }
    }
}
