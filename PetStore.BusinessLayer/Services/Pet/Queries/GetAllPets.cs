using PetStore.BusinessLayer.Dto;
using Microsoft.EntityFrameworkCore;
using PetStore.DataLayer.Common;

namespace PetStore.BusinessLayer.Services.Pet.Queries;

public class GetAllPets(IPetStoreDbContext context)
{
    public async Task<List<PetDto>> ExecuteAsync(CancellationToken cancellationToken = default)
    {
        var pets = await context.Pets.ToListAsync(cancellationToken);
        return pets.Select(x => x.ToDto()).ToList();
    }
}
