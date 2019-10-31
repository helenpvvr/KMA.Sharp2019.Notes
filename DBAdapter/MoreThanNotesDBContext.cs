
using KMA.Sharp2019.Notes.MoreThanNotes.DBAdapter.Migrations;
using KMA.Sharp2019.Notes.MoreThanNotes.DBModels;
using System.Data.Entity;

namespace KMA.Sharp2019.Notes.MoreThanNotes.DBAdapter
{
    internal class MoreThanNotesDBContext : DbContext
    {
        public MoreThanNotesDBContext() : base("MoreThenNotesDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MoreThanNotesDBContext, Configuration>(true));
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new User.UserEntityConfiguration());
            modelBuilder.Configurations.Add(new Note.NoteEntityConfiguration());
        }
    }
}
