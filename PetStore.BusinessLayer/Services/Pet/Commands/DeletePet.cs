using Microsoft.EntityFrameworkCore;
using PetStore.BusinessLayer.Utils;

namespace PetStore.BusinessLayer.Services.Pet.Commands;

public class DeletePet(IPetStoreDbContext context)
{
    public async Task<bool> ExecuteAsync(int petId, CancellationToken cancellationToken = default)
    {
        var pet = await context.Pets.FirstOrDefaultAsync(x => x.Id == petId, cancellationToken);
        if (pet == null) return false;
        pet.IsDeleted = true;
        pet.Deleted = DateTime.Now;
        pet.DeletedBy = "system"; // TODO: Need replace with actual user
        await context.SaveChangesAsync(cancellationToken);
        return true;
    }
}
