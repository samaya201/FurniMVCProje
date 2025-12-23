namespace FurniMVC201.Models;

public class Comment
{
    public int Id { get; set; }
    public string Message { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
    public string isAccepted { get; set; }
}
