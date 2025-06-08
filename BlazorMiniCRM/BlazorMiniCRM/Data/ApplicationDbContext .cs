using Microsoft.EntityFrameworkCore;
using BlazorMiniCRM.Shared.Models;

namespace BlazorMiniCRM.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

        public DbSet<BlazorMiniCRM.Shared.Models.Client> Clients => Set<BlazorMiniCRM.Shared.Models.Client>();
        public DbSet<Order> Orders => Set<Order>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BlazorMiniCRM.Shared.Models.Client>()
                .HasMany(c => c.Orders)
                .WithOne(o => o.Client)
                .HasForeignKey(o => o.ClientId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<BlazorMiniCRM.Shared.Models.Client>().HasData(
                new BlazorMiniCRM.Shared.Models.Client { Id = 1, Name = "Jean Dupont", Email = "jean.dupont@example.com" },
                new BlazorMiniCRM.Shared.Models.Client { Id = 2, Name = "Marie Curie", Email = "marie.curie@example.com" },
                new BlazorMiniCRM.Shared.Models.Client { Id = 3, Name = "Pierre Martin", Email = "pierre.martin@example.com" }
            );

            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 101, ClientId = 1, DateOrder = DateTime.Now.AddDays(-30), Montant = 150.75m },
                new Order { Id = 102, ClientId = 1, DateOrder = DateTime.Now.AddDays(-15), Montant = 220.00m },
                new Order { Id = 103, ClientId = 1, DateOrder = DateTime.Now.AddDays(-30), Montant = 99.50m },
                new Order { Id = 104, ClientId = 2, DateOrder = DateTime.Now.AddDays(-15), Montant = 993.50m },
                new Order { Id = 105, ClientId = 2, DateOrder = DateTime.Now.AddDays(-10), Montant = 999.50m },
                new Order { Id = 106, ClientId = 2, DateOrder = DateTime.Now.AddDays(-30), Montant = 929.50m },
                new Order { Id = 107, ClientId = 3, DateOrder = DateTime.Now.AddDays(-15), Montant = 399.50m },
                new Order { Id = 108, ClientId = 3, DateOrder = DateTime.Now.AddDays(-10), Montant = 199.50m },
                new Order { Id = 109, ClientId = 3, DateOrder = DateTime.Now.AddDays(-30), Montant = 899.50m },
                new Order { Id = 110, ClientId = 1, DateOrder = DateTime.Now.AddDays(-15), Montant = 499.50m },
                new Order { Id = 111, ClientId = 2, DateOrder = DateTime.Now.AddDays(-10), Montant = 699.50m },
                new Order { Id = 112, ClientId = 3, DateOrder = DateTime.Now.AddDays(-130), Montant = 399.50m }
            );
        }
    }
}