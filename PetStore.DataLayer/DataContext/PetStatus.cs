using System.ComponentModel.DataAnnotations.Schema;
using PetStore.DataLayer.Common;

namespace PetStore.DataLayer.DataContext;

public class PetStatus : BaseEntity
{
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = null!;

    public ICollection<Pet> Pets { get; set; } = [];
}