namespace FurniMVC201.Models;

public class Blog
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageName { get; set; }
    public string ImageUrl { get; set; }
    public DateTime PostedDate { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }

}
