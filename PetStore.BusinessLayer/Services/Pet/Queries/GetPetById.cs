using PetStore.BusinessLayer.Dto;
using PetStore.BusinessLayer.Utils;
using Microsoft.EntityFrameworkCore;

namespace PetStore.BusinessLayer.Services.Pet.Queries;

public class GetPetById(IPetStoreDbContext context)
{
    public async Task<PetDto?> ExecuteAsync(int petId, CancellationToken cancellationToken = default)
    {
        var pet = await context.Pets.FirstOrDefaultAsync(x => x.Id == petId, cancellationToken);
        return pet?.ToDto();
    }
}
