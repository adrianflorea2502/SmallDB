using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ProiectBD.DB
{
    public partial class proiectContext : DbContext
    {
        public proiectContext()
        {
        }

        public proiectContext(DbContextOptions<proiectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Developer> Developers { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<GameDeveloper> GameDevelopers { get; set; }
        public virtual DbSet<GamePublisher> GamePublishers { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost,1433;Initial Catalog=proiect;Persist Security Info=True;User ID=SA;Password=parolaAiaPuternic4!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Developer>(entity =>
            {
                entity.Property(e => e.DeveloperId)
                    .ValueGeneratedNever()
                    .HasColumnName("developer_id");

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contact");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.Property(e => e.GameId)
                    .ValueGeneratedNever()
                    .HasColumnName("game_id");

                entity.Property(e => e.DeveloperId).HasColumnName("developer_id");

                entity.Property(e => e.GameName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("game_name");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price");

                entity.Property(e => e.PublisherId).HasColumnName("publisher_id");

                entity.Property(e => e.Rating)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("rating");

                entity.Property(e => e.ReleaseDate)
                    .HasColumnType("date")
                    .HasColumnName("release_date");

                entity.Property(e => e.StorePage)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("store_page");
            });

            modelBuilder.Entity<GameDeveloper>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DeveloperId).HasColumnName("developer_id");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.HasOne(d => d.Developer)
                    .WithMany()
                    .HasForeignKey(d => d.DeveloperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GameDevelopers_Developers");

                entity.HasOne(d => d.Game)
                    .WithMany()
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GameDevelopers_Games");
            });

            modelBuilder.Entity<GamePublisher>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.PublisherId).HasColumnName("publisher_id");

                entity.HasOne(d => d.Game)
                    .WithMany()
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GamePublishers_Games");

                entity.HasOne(d => d.Publisher)
                    .WithMany()
                    .HasForeignKey(d => d.PublisherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GamePublishers_Publishers");
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.Property(e => e.PublisherId)
                    .ValueGeneratedNever()
                    .HasColumnName("publisher_id");

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contact");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
