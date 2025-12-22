namespace FurniMVC201.Models;

public class Product
{
    public int Id { get; set; }
   public string Name { get; set; }
    public string ImageName { get; set; }
    public string ImageUrl { get; set; }
    public decimal Price { get; set; }
    public DateTime CreatedData { get; set; }

    public DateTime? UpdateData { get; set; }
    public bool IsDeleted { get; set; }
}
