using PetStore.BusinessLayer.Dto;
using PetStore.BusinessLayer.Utils;
using Microsoft.EntityFrameworkCore;

namespace PetStore.BusinessLayer.Services.Order.Queries;

public class GetAllOrders(IPetStoreDbContext context)
{
    public async Task<List<OrderDto>> ExecuteAsync(CancellationToken cancellationToken = default)
    {
        var orders = await context.Orders.ToListAsync(cancellationToken);
        return orders.Select(x => x.ToDto()).ToList();
    }
}
