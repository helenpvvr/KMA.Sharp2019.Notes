using System.Data.Entity.ModelConfiguration;
using KMA.Sharp2019.Notes.MoreThanNotes.DBModels;

namespace KMA.Sharp2019.Notes.MoreThanNotes.DBAdapter.ModelConfiguration
{
    public class NoteEntityConfiguration : EntityTypeConfiguration<Note>
    {
        public NoteEntityConfiguration()
        {
            ToTable("Notes");
            HasKey(n => n.Guid);

            Property(p => p.Guid)
                .HasColumnName("Guid")
                .IsRequired();
            Property(p => p.Title)
                .HasColumnName("Title")
                .IsRequired();
            Property(p => p.NoteText)
                .HasColumnName("NoteText")
                .IsRequired();
            Property(p => p.CreatedDateTime)
                .HasColumnName("CreatedDateTime")
                .IsRequired();
            Property(p => p.EditedDateTime)
                .HasColumnName("EditedDateTime")
                .IsRequired();
        }
    }
}
