
using KMA.Sharp2019.Notes.MoreThanNotes.DBAdapter.Migrations;
using KMA.Sharp2019.Notes.MoreThanNotes.DBModels;
using System.Data.Entity;
using KMA.Sharp2019.Notes.MoreThanNotes.DBAdapter.ModelConfiguration;

namespace KMA.Sharp2019.Notes.MoreThanNotes.DBAdapter
{
    public class MoreThanNotesDBContext : DbContext
    {
        public MoreThanNotesDBContext() : base("MoreThenNotesDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MoreThanNotesDBContext, Configuration>(true));
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserEntityConfiguration());
            modelBuilder.Configurations.Add(new NoteEntityConfiguration());
        }
    }
}
