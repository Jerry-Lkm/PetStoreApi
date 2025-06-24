namespace PetStore.BusinessLayer.Dto;

public class PetDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int Category { get; set; }
    public int Status { get; set; }
    public string Tags { get; set; } = null!;
}
