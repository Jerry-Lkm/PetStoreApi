using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetStore.DataLayer.Common;

namespace PetStore.DataLayer.DataContext;

public class Pet : BaseEntity
{
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = null!;

    [Column("category")]
    public string Category { get; set; } = null!;

    [Column("status")]
    public string Status { get; set; } = null!;

    [Column("tags")]
    public string Tags { get; set; } = null!;

    [Timestamp]
    public byte[] RowVersion { get; set; } = null!;

    public PetStatus PetStatus { get; set; } = null!;
    public ICollection<Order> Orders { get; set; } = [];
}