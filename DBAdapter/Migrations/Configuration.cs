namespace KMA.Sharp2019.Notes.MoreThanNotes.DBAdapter.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KMA.Sharp2019.Notes.MoreThanNotes.DBAdapter.MoreThanNotesDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(KMA.Sharp2019.Notes.MoreThanNotes.DBAdapter.MoreThanNotesDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
