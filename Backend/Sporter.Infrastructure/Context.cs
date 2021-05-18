using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sporter.Domain.Models;

namespace Sporter.Infrastructure
{
    public class Context : IdentityDbContext
    {
        // public Context(DbContextOptions options) : base(options)
        // {
        // }

        public DbSet<UserModel> UserModels { get; set; }
        public DbSet<AuctionModel> AuctionModels { get; set; }
        public DbSet<ItemModel> ItemModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=SporterDevelopment;User Id=sa;Password=Localhost1;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserModel>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<ItemModel>()
                .HasKey(i => i.Id);

            modelBuilder.Entity<AuctionModel>()
                .HasKey(it => new { it.UserId, it.ItemId });


            modelBuilder.Entity<AuctionModel>()
                .HasOne(a => a.User)
                .WithMany(u => u.Auctions)
                .HasForeignKey(a => a.UserId);

            modelBuilder.Entity<AuctionModel>()
                .HasOne(a => a.Item)
                .WithOne(u => u.Auction)
                .HasForeignKey<AuctionModel>(a => a.ItemId);

           

        }
    }
}