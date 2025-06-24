using PetStore.BusinessLayer.Utils;
using Microsoft.EntityFrameworkCore;

namespace PetStore.BusinessLayer.Services.Order.Commands;

public class DeleteOrder(IPetStoreDbContext context)
{
    public async Task<bool> ExecuteAsync(int orderId, CancellationToken cancellationToken = default)
    {
        var order = await context.Orders.FirstOrDefaultAsync(x => x.Id == orderId, cancellationToken);
        if (order == null) return false;
        order.IsDeleted = true;
        order.Deleted = DateTime.Now;
        order.DeletedBy = "system"; // TODO: Need replace with actual user
        await context.SaveChangesAsync(cancellationToken);
        return true;
    }
}
