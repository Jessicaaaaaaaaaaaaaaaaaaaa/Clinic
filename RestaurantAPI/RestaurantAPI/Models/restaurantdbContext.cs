using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RestaurantAPI.Models
{
    public partial class restaurantdbContext : DbContext
    {
        public restaurantdbContext()
        {
        }

        public restaurantdbContext(DbContextOptions<restaurantdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Menuitem> Menuitems { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Reservationmenuitem> Reservationmenuitems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // #warning 
                optionsBuilder.UseMySql("server=localhost;username=root;password=qnQCqHAvtXqOSksz;database=restaurantdb", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.31-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            modelBuilder.Entity<Menuitem>(entity =>
            {
                entity.ToTable("menuitems");

                entity.HasIndex(e => e.Id, "idMenuItems_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.ToTable("reservations");

                entity.HasIndex(e => e.Id, "idReservations_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Reservationmenuitem>(entity =>
            {
                entity.HasKey(e => new { e.IdReservations, e.IdMenuItems })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("reservationmenuitems");

                entity.HasIndex(e => e.IdMenuItems, "fk_Reservations_has_MenuItems_MenuItems1_idx");

                entity.HasIndex(e => e.IdReservations, "fk_Reservations_has_MenuItems_Reservations_idx");

                entity.Property(e => e.IdReservations)
                    .HasColumnType("int(11)")
                    .HasColumnName("idReservations");

                entity.Property(e => e.IdMenuItems)
                    .HasColumnType("int(11)")
                    .HasColumnName("_idMenuItems");

                entity.HasOne(d => d.IdMenuItem)
                    .WithMany(p => p.Reservationmenuitems)
                    .HasForeignKey(d => d.IdMenuItems)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Reservations_has_MenuItems_MenuItems1");

                entity.HasOne(d => d.IdReservation)
                    .WithMany(p => p.Reservationmenuitems)
                    .HasForeignKey(d => d.IdReservations)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Reservations_has_MenuItems_Reservations");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
