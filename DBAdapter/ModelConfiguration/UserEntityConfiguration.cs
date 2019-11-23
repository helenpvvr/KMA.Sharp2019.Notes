using System.Data.Entity.ModelConfiguration;
using KMA.Sharp2019.Notes.MoreThanNotes.DBModels;

namespace KMA.Sharp2019.Notes.MoreThanNotes.DBAdapter.ModelConfiguration
{
    public class UserEntityConfiguration : EntityTypeConfiguration<User>
    {
        public UserEntityConfiguration()
        {
            ToTable("Users");
            HasKey(u => u.Guid);

            Property(u => u.Guid).HasColumnName("Guid").IsRequired();
            Property(u => u.FirstName).HasColumnName("FirstName").IsRequired();
            Property(u => u.LastName).HasColumnName("LastName").IsRequired();
            Property(u => u.LastSingInDate).HasColumnName("LastSingInDate").IsRequired();
            Property(u => u.Login).HasColumnName("Login").IsRequired();
            Property(u => u.Email).HasColumnName("Email").IsRequired();
            Property(u => u.Password).HasColumnName("Password").IsRequired();

            HasMany(u => u.Notes).WithRequired(n => n.User).HasForeignKey(n => n.UserGuid).WillCascadeOnDelete(true);
        }
    }
}
