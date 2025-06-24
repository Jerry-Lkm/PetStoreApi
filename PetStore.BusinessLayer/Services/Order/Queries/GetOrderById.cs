using PetStore.BusinessLayer.Dto;
using Microsoft.EntityFrameworkCore;
using PetStore.DataLayer.Common;

namespace PetStore.BusinessLayer.Services.Order.Queries;

public class GetOrderById(IPetStoreDbContext context)
{
    public async Task<OrderDto?> ExecuteAsync(int orderId, CancellationToken cancellationToken = default)
    {
        var order = await context.Orders.FirstOrDefaultAsync(x => x.Id == orderId, cancellationToken);
        return order?.ToDto();
    }
}
