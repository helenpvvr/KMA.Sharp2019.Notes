namespace KMA.Sharp2019.Notes.MoreThanNotes.DBAdapter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Guid = c.Guid(nullable: false),
                        Title = c.String(nullable: false),
                        NoteText = c.String(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        EditedDateTime = c.DateTime(nullable: false),
                        UserGuid = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Guid)
                .ForeignKey("dbo.Users", t => t.UserGuid, cascadeDelete: true)
                .Index(t => t.UserGuid);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Guid = c.Guid(nullable: false),
                        Login = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Guid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notes", "UserGuid", "dbo.Users");
            DropIndex("dbo.Notes", new[] { "UserGuid" });
            DropTable("dbo.Users");
            DropTable("dbo.Notes");
        }
    }
}
