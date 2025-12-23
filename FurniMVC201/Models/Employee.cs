namespace FurniMVC201.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public List<Blog> Blogs { get; set; }

        public List<Comment> Comments { get; set; }

        public string ImageUrl { get; set; }
      
    }
}
