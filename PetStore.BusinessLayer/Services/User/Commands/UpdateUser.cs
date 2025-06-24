using PetStore.BusinessLayer.Dto;
using Microsoft.EntityFrameworkCore;
using PetStore.DataLayer.Common;

namespace PetStore.BusinessLayer.Services.User.Commands;

public class UpdateUser(IPetStoreDbContext context)
{
    public async Task<UserDto?> ExecuteAsync(UserDto request, CancellationToken cancellationToken = default)
    {
        DataLayer.DataContext.User? user = await context.Users.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        if (user == null)
        {
            return null; // User not found
        }
        user.FirstName = request.FirstName;
        user.LastName = request.LastName;
        user.Email = request.Email;
        context.Users.Update(user);
        await context.SaveChangesAsync(cancellationToken);
        return user.ToDto();
    }
}
