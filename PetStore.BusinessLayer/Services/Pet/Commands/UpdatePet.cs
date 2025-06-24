using Microsoft.EntityFrameworkCore;
using PetStore.BusinessLayer.Dto;
using PetStore.DataLayer.Common;

namespace PetStore.BusinessLayer.Services.Pet.Commands;

public class UpdatePet(IPetStoreDbContext context)
{
    public async Task<PetDto?> ExecuteAsync(PetDto request, CancellationToken cancellationToken = default)
    {
        var item = await context.Pets.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        if (item == null) return null;
        item.Name = request.Name;
        item.Category = request.Category;
        item.Status = request.Status;

        context.Pets.Update(item);
        await context.SaveChangesAsync(cancellationToken);
        return item.ToDto();
    }
}
