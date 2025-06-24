using PetStore.BusinessLayer.Dto;
using PetStore.BusinessLayer.Utils;
using Microsoft.EntityFrameworkCore;

namespace PetStore.BusinessLayer.Services.User.Queries;

public class GetUserById(IPetStoreDbContext context)
{
    public async Task<UserDto?> ExecuteAsync(int userId, CancellationToken cancellationToken = default)
    {
        var user = await context.Users.FirstOrDefaultAsync(x => x.Id == userId, cancellationToken);
        return user?.ToDto();
    }
}
