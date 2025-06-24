using Microsoft.EntityFrameworkCore;
using PetStore.DataLayer.Common.Enum;
using PetStore.DataLayer.DataContext;

namespace PetStore.DataLayer;

public partial class PetStoreDbContext : DbContext
{
    public PetStoreDbContext() { }
    public PetStoreDbContext(DbContextOptions<PetStoreDbContext> options)
        : base(options)
    {
    }

    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<OrderStatus> OrderStatuses { get; set; } = null!;
    public DbSet<Pet> Pets { get; set; } = null!;
    public DbSet<PetCategory> PetCategories { get; set; } = null!;
    public DbSet<PetStatus> PetStatuses { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<UserStatus> UserStatuses { get; set; } = null!;

    // Uncomment and configure the connection string as needed
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlServer("Server={server},{port};Database={database};User Id={user};Password={password};TrustServerCertificate=True;MultipleActiveResultSets=True;Encrypt=False;");
    // }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Row version for concurrency control
        modelBuilder.Entity<Order>()
            .Property(o => o.RowVersion)
            .IsRowVersion();

        modelBuilder.Entity<Pet>()
            .Property(p => p.RowVersion)
            .IsRowVersion();

        modelBuilder.Entity<User>()
            .Property(u => u.RowVersion)
            .IsRowVersion();

        // Relationships
        modelBuilder.Entity<Order>()
            .HasOne(o => o.OrderStatus)
            .WithMany(os => os.Orders)
            .HasForeignKey(o => o.Status)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Order>()
            .HasOne(o => o.Pet)
            .WithMany(p => p.Orders)
            .HasForeignKey(o => o.PetId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Pet>()
            .HasOne(p => p.PetStatus)
            .WithMany(ps => ps.Pets)
            .HasForeignKey(p => p.Status)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<PetCategory>()
            .HasMany(pc => pc.Pets)
            .WithOne(o => o.PetCategory)
            .HasForeignKey(p => p.Category)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<User>()
            .HasOne(u => u.UserStatus)
            .WithMany(us => us.Users)
            .HasForeignKey(u => u.Status)
            .OnDelete(DeleteBehavior.Restrict);

        // Seeding OrderStatus
        modelBuilder.Entity<OrderStatus>().HasData(
            new OrderStatus { Id = (int)OrderStatusEnum.Placed, Name = OrderStatusEnum.Placed.ToString(), CreatedBy = "system" },
            new OrderStatus { Id = (int)OrderStatusEnum.Processing, Name = OrderStatusEnum.Processing.ToString(), CreatedBy = "system" },
            new OrderStatus { Id = (int)OrderStatusEnum.Shipped, Name = OrderStatusEnum.Shipped.ToString(), CreatedBy = "system" }
        );

        // Seeding PetCategory
        modelBuilder.Entity<PetCategory>().HasData(
            new PetCategory { Id = (int)PetCategoryEnum.Dog, Name = PetCategoryEnum.Dog.ToString(), CreatedBy = "system" },
            new PetCategory { Id = (int)PetCategoryEnum.Cat, Name = PetCategoryEnum.Cat.ToString(), CreatedBy = "system" },
            new PetCategory { Id = (int)PetCategoryEnum.Bunny, Name = PetCategoryEnum.Bunny.ToString(), CreatedBy = "system" }
        );

        // Seeding PetStatus
        modelBuilder.Entity<PetStatus>().HasData(
            new PetStatus { Id = (int)PetStatusEnum.Available, Name = PetStatusEnum.Available.ToString(), CreatedBy = "system" },
            new PetStatus { Id = (int)PetStatusEnum.Pending, Name = PetStatusEnum.Pending.ToString(), CreatedBy = "system" },
            new PetStatus { Id = (int)PetStatusEnum.Sold, Name = PetStatusEnum.Sold.ToString(), CreatedBy = "system" }
        );

        // Seeding UserStatus
        modelBuilder.Entity<UserStatus>().HasData(
            new UserStatus { Id = (int)UserStatusEnum.Active, Name = UserStatusEnum.Active.ToString(), CreatedBy = "system" },
            new UserStatus { Id = (int)UserStatusEnum.Inactive, Name = UserStatusEnum.Inactive.ToString(), CreatedBy = "system" }
        );
    }
}
