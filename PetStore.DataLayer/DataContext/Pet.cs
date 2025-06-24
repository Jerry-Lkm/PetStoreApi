using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetStore.DataLayer.Common;

namespace PetStore.DataLayer.DataContext;

[Table("Pet")]
public class Pet : BaseEntity
{
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = null!;

    [Column("category")]
    public int Category { get; set; }

    [Column("status")]
    public int Status { get; set; }

    [Column("tags")]
    public string Tags { get; set; } = null!;

    [Timestamp]
    public byte[] RowVersion { get; set; } = null!;

    public PetCategory PetCategory { get; set; } = null!;
    public PetStatus PetStatus { get; set; } = null!;
    public ICollection<Order> Orders { get; set; } = [];
}