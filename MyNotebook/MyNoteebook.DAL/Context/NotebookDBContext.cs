using Microsoft.EntityFrameworkCore;
using MyNoteebook.DAL.DBModels;

namespace MyNoteebook.DAL.Context
{
    public class NotebookDBContext : DbContext
    {
        public NotebookDBContext()
        {
        }

        public NotebookDBContext(DbContextOptions<NotebookDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Notebook> Notebook { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=NotebookDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Notebook>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.MainInformation).HasMaxLength(1000);

                entity.Property(e => e.ShortDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
