using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetStore.DataLayer.Common;

namespace PetStore.DataLayer.DataContext;

public class Order : BaseEntity
{
    [Column("id")]
    public int Id { get; set; }

    [Column("petId")]
    public int PetId { get; set; }

    [Column("quantity")]
    public int Quantity { get; set; }

    [Column("shipDate")]
    public DateTime ShipDate { get; set; }

    [Column("status")]
    public int Status { get; set; }

    [Column("complete")]
    public bool Complete { get; set; }

    [Timestamp]
    public byte[] RowVersion { get; set; } = null!;

    public OrderStatus OrderStatus { get; set; } = null!;
    public Pet Pet { get; set; } = null!;
}