using System.ComponentModel.DataAnnotations.Schema;

namespace PetStore.DataLayer.Common;

public class BaseEntity
{
    [Column("createdby")]
    public required string CreatedBy { get; set; }

    [Column("created")]
    public DateTime Created { get; set; }

    [Column("modifiedby")]
    public string? ModifiedBy { get; set; }

    [Column("modified")]
    public DateTime? Modified { get; set; }

    [Column("deletedBy")]
    public string? DeletedBy { get; set; }

    [Column("deleted")]
    public DateTime? Deleted { get; set; }

    [Column("isdeleted")]
    public bool IsDeleted { get; set; } = false;
}