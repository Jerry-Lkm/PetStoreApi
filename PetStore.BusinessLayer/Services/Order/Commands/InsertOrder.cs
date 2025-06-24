using PetStore.BusinessLayer.Dto;
using PetStore.DataLayer.Common;

namespace PetStore.BusinessLayer.Services.Order.Commands;

public class InsertOrder(IPetStoreDbContext context)
{
    private readonly IPetStoreDbContext _context = context;

    public async Task<OrderDto> ExecuteAsync(OrderDto order, CancellationToken cancellationToken = default)
    {
        DataLayer.DataContext.Order newOrder = order.ToEntity();
        await _context.Orders.AddAsync(newOrder, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return order;
    }
}
