using Microsoft.AspNetCore.Mvc;
using PetStore.BusinessLayer.Dto;
using PetStore.BusinessLayer.Services.Pet.Commands;
using PetStore.BusinessLayer.Services.Pet.Queries;
using PetStore.DataLayer.Common;

namespace PetStore.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PetController : ControllerBase
{
    private readonly IPetStoreDbContext _context;
    public PetController(IPetStoreDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var service = new GetAllPets(_context);
        return Ok(await service.ExecuteAsync(cancellationToken));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id, CancellationToken cancellationToken)
    {
        var service = new GetPetById(_context);
        var pet = await service.ExecuteAsync(id, cancellationToken);
        if (pet == null) return NotFound();
        return Ok(pet);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] PetDto dto, CancellationToken cancellationToken)
    {
        var service = new InsertPet(_context);
        return Ok(await service.ExecuteAsync(dto, cancellationToken));
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] PetDto dto, CancellationToken cancellationToken)
    {
        var service = new UpdatePet(_context);
        dto.Id = id;
        var updated = await service.ExecuteAsync(dto, cancellationToken);
        if (updated == null) return NotFound();
        return Ok(updated);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
    {
        var service = new DeletePet(_context);
        var deleted = await service.ExecuteAsync(id, cancellationToken);
        if (!deleted) return NotFound();
        return NoContent();
    }
}
