namespace PetStore.BusinessLayer.Dto;

public class OrderDto
{
    public int Id { get; set; }
    public int PetId { get; set; }
    public int Quantity { get; set; }
    public DateTime ShipDate { get; set; }
    public int Status { get; set; }
    public bool Complete { get; set; }
}
