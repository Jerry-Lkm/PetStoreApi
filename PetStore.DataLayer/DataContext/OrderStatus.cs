using System.ComponentModel.DataAnnotations.Schema;
using PetStore.DataLayer.Common;

namespace PetStore.DataLayer.DataContext;

public class OrderStatus : BaseEntity
{
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = null!;

    public ICollection<Order> Orders { get; set; } = [];
}