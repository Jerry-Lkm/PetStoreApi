using PetStore.BusinessLayer.Dto;
using Microsoft.EntityFrameworkCore;
using PetStore.DataLayer.Common;

namespace PetStore.BusinessLayer.Services.User.Queries;

public class GetAllUsers(IPetStoreDbContext context)
{
    public async Task<List<UserDto>> ExecuteAsync(CancellationToken cancellationToken = default)
    {
        var users = await context.Users.ToListAsync(cancellationToken);
        return users.Select(x => x.ToDto()).ToList();
    }
}
