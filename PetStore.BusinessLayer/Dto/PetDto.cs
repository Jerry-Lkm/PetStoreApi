namespace PetStore.BusinessLayer.Dto;

public class PetDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Category { get; set; } = null!;
    public string Status { get; set; } = null!;
    public string Tags { get; set; } = null!;
}
