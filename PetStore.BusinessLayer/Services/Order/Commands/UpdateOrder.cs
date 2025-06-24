using DataContextOrder = PetStore.DataLayer.DataContext.Order;
using PetStore.DataLayer.Common;

namespace PetStore.BusinessLayer.Services.Order.Commands;

public class UpdateOrder(IPetStoreDbContext context)
{
    public async Task<DataContextOrder?> ExecuteAsync(DataContextOrder order, CancellationToken cancellationToken = default)
    {
        context.Orders.Update(order);
        await context.SaveChangesAsync(cancellationToken);
        return order;
    }
}
