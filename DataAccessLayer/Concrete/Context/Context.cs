using System;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
        //bu kısımda identity öncesi DbContext den miras alıyordu ama identitiy işlemleri sonrası deiştirerek IdentitityDbContexten miras aldırıdk

	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=ChatAppDb;User Id=postgres;Password=12345678;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany(u => u.Senders)
                .HasForeignKey(m => m.SenderId);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Receiver)
                .WithMany(u => u.Receivers)
                .HasForeignKey(m => m.ReceiverId);
            
            modelBuilder.Entity<Message>()
            .HasIndex(m => m.ReRecieverMail)
            .IsUnique();
        }

        //Message sınıfının Sender ve Receiver özelliklerini kullanarak AppUser sınıfıyla ilişkilendirir ve bir mesajın göndericisinin ve alıcısının kim olduğunu belirler.
        //Bu kod, Message sınıfının Sender ve Receiver özelliklerinin AppUser sınıfı ile ilişkilendirilmesini sağlar. SenderID ve ReceiverID alanları da kullanıcının anahtar alanlarını gösterir.

        public DbSet<Message> Messages { get; set; }
        public DbSet<Priority> Priorities { get; set; }
    }
}

