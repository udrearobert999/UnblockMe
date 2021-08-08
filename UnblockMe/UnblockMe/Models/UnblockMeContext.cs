using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UnblockMe.Models
{
    public partial class UnblockMeContext : IdentityDbContext<Users>
    {
        public UnblockMeContext()
        {
        }

        public UnblockMeContext(DbContextOptions<UnblockMeContext> options)
            : base(options)
        {
        }


        public virtual DbSet<Users> AspNetUsers { get; set; }
        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<Ratings> Ratings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-IM9BTPQ;Database=UnblockMe;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cars>(entity =>
            {
                entity.HasKey(e => e.LicensePlate)
                     .HasName("PK__Cars__F72CD56F0D7E960E");

                entity.Property(e => e.LicensePlate)
                    .HasColumnName("license_plate")
                    .HasMaxLength(20);

                entity.Property(e => e.BlocksCar)
                    .HasColumnName("blocks_car")
                    .HasMaxLength(20);

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasColumnName("brand")
                    .HasMaxLength(20);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnName("color")
                    .HasMaxLength(20);

                entity.Property(e => e.IsBlockedByCar)
                    .HasColumnName("is_blocked_by_car")
                    .HasMaxLength(20);

                entity.Property(e => e.OwnerId).HasColumnName("owner_id");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cars_ref_to_Users");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.FirstName);
                entity.Property(e => e.LastName);
                entity.Property(e => e.ProfilePicture);
            });
            modelBuilder.Entity<Ratings>(entity =>
            {
                entity.HasKey(e => new
                {
                    e.rated_id,
                    e.rater_id
                }).HasName("PK__Ratings__C73B45F5134054E5");

                entity.Property(e => e.rater_id)
                        .HasColumnName("rater_id")
                        .IsRequired()
                        .HasMaxLength(450);

                entity.Property(e => e.rated_id)        
                .HasColumnName("rated_id")
                        .IsRequired()
                        .HasMaxLength(450);

                entity.Property(e => e.rating_message)
                        .HasColumnName("rating_message");


                entity.Property(e => e.rating_value)
                        .HasColumnName("rating_value");

                entity.HasOne(d => d.Rater)
                      .WithMany(u => u.RatesGiven)
                      .HasForeignKey(d => d.rater_id)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("FK_rater_users");

                entity.HasOne(d => d.Rated)
                      .WithMany(u => u.RatesGot)
                      .HasForeignKey(d => d.rated_id)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("FK_rated_users");





            });

            OnModelCreatingPartial(modelBuilder);

        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
