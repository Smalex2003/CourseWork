using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CourseWork
{
    public partial class PhotoStorageContext : DbContext
    {
        public PhotoStorageContext()
        {
        }

        public PhotoStorageContext(DbContextOptions<PhotoStorageContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuthorOfPhoto> AuthorOfPhoto { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<PlaceOfPhoto> PlaceOfPhoto { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("datasource=C:\\CourseWork\\PhotoStorage.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorOfPhoto>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnType("TEXT (100)");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnType("TEXT (100)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("TEXT (100)");

                entity.Property(e => e.House)
                    .IsRequired()
                    .HasColumnType("TEXT (100)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("TEXT (100)");

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasColumnType("TEXT (100)");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnType("TEXT (100)");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.AuthorOfPhoto)
                    .HasForeignKey<AuthorOfPhoto>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.AddTime).IsRequired();

                entity.Property(e => e.AuthorOfPhotoId).HasColumnName("AuthorOfPhotoID");

                entity.Property(e => e.Format)
                    .IsRequired()
                    .HasColumnType("TEXT (4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("TEXT (100)");

                entity.Property(e => e.Photo1)
                    .IsRequired()
                    .HasColumnName("Photo");

                entity.HasOne(d => d.AuthorOfPhotoNavigation)
                    .WithMany(p => p.Photo)
                    .HasForeignKey(d => d.AuthorOfPhotoId);

                entity.HasOne(d => d.PlaceOfPhoto)
                    .WithMany(p => p.Photo)
                    .HasForeignKey(d => d.PlaceOfPhotoId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Photo)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PlaceOfPhoto>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnType("TEXT (100)");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnType("TEXT (100)");

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasColumnType("TEXT (100)");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.PlaceOfPhotoNavigation)
                    .HasForeignKey<PlaceOfPhoto>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("TEXT (100)");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnType("TEXT (100)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("TEXT (100)");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasColumnType("TEXT (100)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
