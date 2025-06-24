using PetStore.DataLayer.DataContext;

namespace PetStore.BusinessLayer.Dto;

public static class MappingProfile
{
    public static PetDto ToDto(this Pet pet)
    {
        return new PetDto
        {
            Id = pet.Id,
            Name = pet.Name,
            Category = pet.Category,
            Status = pet.Status,
            Tags = pet.Tags
        };
    }

    public static Pet ToEntity(this PetDto dto)
    {
        return new Pet
        {
            Id = dto.Id,
            Name = dto.Name,
            Category = dto.Category,
            Status = dto.Status,
            Tags = dto.Tags,
            CreatedBy = "system"
        };
    }

    public static UserDto ToDto(this User user)
    {
        return new UserDto
        {
            Id = user.Id,
            UserName = user.UserName,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            Phone = user.Phone,
            Status = user.Status
        };
    }

    public static User ToEntity(this UserDto dto)
    {
        return new User
        {
            Id = dto.Id,
            UserName = dto.UserName,
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Email = dto.Email,
            Phone = dto.Phone,
            Status = dto.Status,
            CreatedBy = "system"
        };
    }

    public static OrderDto ToDto(this Order order)
    {
        return new OrderDto
        {
            Id = order.Id,
            PetId = order.PetId,
            Quantity = order.Quantity,
            ShipDate = order.ShipDate,
            Status = order.Status,
            Complete = order.Complete
        };
    }

    public static Order ToEntity(this OrderDto dto)
    {
        return new Order
        {
            Id = dto.Id,
            PetId = dto.PetId,
            Quantity = dto.Quantity,
            ShipDate = dto.ShipDate,
            Status = dto.Status,
            Complete = dto.Complete,
            CreatedBy = "system"
        };
    }
}
