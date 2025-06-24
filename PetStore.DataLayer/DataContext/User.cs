using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetStore.DataLayer.Common;

namespace PetStore.DataLayer.DataContext;

public class User : BaseEntity
{
    [Column("id")]
    public int Id { get; set; }

    [Column("userName")]
    public string UserName { get; set; } = null!;

    [Column("firstName")]
    public string FirstName { get; set; } = null!;

    [Column("lastName")]
    public string LastName { get; set; } = null!;

    [Column("email")]
    public string Email { get; set; } = null!;

    [Column("passwordHash")]
    public string PasswordHash { get; set; } = null!;

    [Column("salt")]
    public string Salt { get; set; } = null!;

    [Column("phone")]
    public string Phone { get; set; } = null!;

    [Column("status")]
    public string Status { get; set; } = null!;

    [Timestamp]
    public byte[] RowVersion { get; set; } = null!;

    public UserStatus UserStatus { get; set; } = null!;
}