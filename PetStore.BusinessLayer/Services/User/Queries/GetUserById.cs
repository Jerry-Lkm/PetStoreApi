using PetStore.BusinessLayer.Dto;
using Microsoft.EntityFrameworkCore;
using PetStore.DataLayer.Common;

namespace PetStore.BusinessLayer.Services.User.Queries;

public class GetUserById(IPetStoreDbContext context)
{
    public async Task<UserDto?> ExecuteAsync(int userId, CancellationToken cancellationToken = default)
    {
        var user = await context.Users.FirstOrDefaultAsync(x => x.Id == userId, cancellationToken);
        return user?.ToDto();
    }
}
