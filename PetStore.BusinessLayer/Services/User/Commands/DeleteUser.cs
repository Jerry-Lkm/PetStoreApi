using Microsoft.EntityFrameworkCore;
using PetStore.DataLayer.Common;

namespace PetStore.BusinessLayer.Services.User.Commands;

public class DeleteUser(IPetStoreDbContext context)
{
    public async Task<bool> ExecuteAsync(int userId, CancellationToken cancellationToken = default)
    {
        var user = await context.Users.FirstOrDefaultAsync(x => x.Id == userId, cancellationToken);
        if (user == null) return false;
        user.IsDeleted = true;
        user.Deleted = DateTime.Now;
        user.DeletedBy = "system"; // TODO: Need replace with actual user
        await context.SaveChangesAsync(cancellationToken);
        return true;
    }
}
