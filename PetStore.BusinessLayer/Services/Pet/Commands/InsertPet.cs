using PetStore.BusinessLayer.Utils;
using PetStore.BusinessLayer.Dto;

namespace PetStore.BusinessLayer.Services.Pet.Commands;

public class InsertPet(IPetStoreDbContext context)
{
    public async Task<PetDto> ExecuteAsync(PetDto pet, CancellationToken cancellationToken = default)
    {
        DataLayer.DataContext.Pet newPet = pet.ToEntity();
        await context.Pets.AddAsync(newPet, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
        return pet;
    }
}
