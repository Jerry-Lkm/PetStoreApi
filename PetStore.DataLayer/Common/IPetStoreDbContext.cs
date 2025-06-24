using Microsoft.EntityFrameworkCore;
using PetStore.DataLayer.DataContext;

namespace PetStore.DataLayer.Common;

public interface IPetStoreDbContext
{
    // DbSet properties for each entity type
    DbSet<Order> Orders { get; }
    DbSet<OrderStatus> OrderStatuses { get; }
    DbSet<Pet> Pets { get; }
    DbSet<PetCategory> PetCategories { get; }
    DbSet<PetStatus> PetStatuses { get; }
    DbSet<User> Users { get; }
    DbSet<UserStatus> UserStatuses { get; }

    // Save changes method
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}