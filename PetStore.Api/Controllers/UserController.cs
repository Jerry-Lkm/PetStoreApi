using Microsoft.AspNetCore.Mvc;
using PetStore.BusinessLayer.Dto;
using PetStore.BusinessLayer.Services.User.Commands;
using PetStore.BusinessLayer.Services.User.Queries;
using PetStore.DataLayer.Common;

namespace PetStore.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IPetStoreDbContext _context;
    public UserController(IPetStoreDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var service = new GetAllUsers(_context);
        return Ok(await service.ExecuteAsync(cancellationToken));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id, CancellationToken cancellationToken)
    {
        var service = new GetUserById(_context);
        var user = await service.ExecuteAsync(id, cancellationToken);
        if (user == null) return NotFound();
        return Ok(user);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] UserDto dto, CancellationToken cancellationToken)
    {
        var service = new InsertUser(_context);
        return Ok(await service.ExecuteAsync(dto, cancellationToken));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] UserDto dto, CancellationToken cancellationToken)
    {
        var service = new UpdateUser(_context);
        dto.Id = id;
        var updated = await service.ExecuteAsync(dto, cancellationToken);
        if (updated == null) return NotFound();
        return Ok(updated);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
    {
        var service = new DeleteUser(_context);
        var deleted = await service.ExecuteAsync(id, cancellationToken);
        if (!deleted) return NotFound();
        return NoContent();
    }
}
