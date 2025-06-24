using PetStore.BusinessLayer.Dto;
using PetStore.DataLayer.Common;

namespace PetStore.BusinessLayer.Services.User.Commands;

public class InsertUser(IPetStoreDbContext context)
{
    public async Task<UserDto> ExecuteAsync(UserDto user, CancellationToken cancellationToken = default)
    {
        DataLayer.DataContext.User newUser = user.ToEntity();
        await context.Users.AddAsync(newUser, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
        return newUser.ToDto();
    }
}
