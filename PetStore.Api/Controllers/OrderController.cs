using Microsoft.AspNetCore.Mvc;
using PetStore.BusinessLayer.Dto;
using PetStore.BusinessLayer.Services.Order.Commands;
using PetStore.BusinessLayer.Services.Order.Queries;
using PetStore.DataLayer.Common;

namespace PetStore.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    private readonly IPetStoreDbContext _context;
    public OrderController(IPetStoreDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var service = new GetAllOrders(_context);
        return Ok(await service.ExecuteAsync(cancellationToken));
    }

    [HttpGet("/v1/store/order/{id}")]
    public async Task<IActionResult> Get(int id, CancellationToken cancellationToken)
    {
        var service = new GetOrderById(_context);
        var order = await service.ExecuteAsync(id, cancellationToken);
        if (order == null) return NotFound();
        return Ok(order);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] OrderDto dto, CancellationToken cancellationToken)
    {
        var service = new InsertOrder(_context);
        return Ok(await service.ExecuteAsync(dto, cancellationToken));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] OrderDto dto, CancellationToken cancellationToken)
    {
        var service = new UpdateOrder(_context);
        var entity = dto.ToEntity();
        entity.Id = id;
        var updated = await service.ExecuteAsync(entity, cancellationToken);
        if (updated == null) return NotFound();
        return Ok(updated);
    }

    [HttpDelete("/v1/store/order/{id}")]
    public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
    {
        var service = new DeleteOrder(_context);
        var deleted = await service.ExecuteAsync(id, cancellationToken);
        if (!deleted) return NotFound();
        return NoContent();
    }
}
