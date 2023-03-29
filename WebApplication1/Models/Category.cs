namespace WebApplication1.Models;

public class Category
{
    public int Id { get; set; }
    public string name { get; set; }
    public int quantity { get; set; }
    public string Description { get; set; }
    
    public Category(int id, string name, int quantity, string description)
    {
        this.Id = id;
        this.name = name;
        this.quantity = quantity;
        this.Description = description;
    }
}