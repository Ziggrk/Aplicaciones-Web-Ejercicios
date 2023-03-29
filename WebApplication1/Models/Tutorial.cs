namespace WebApplication1.Models;

public class Tutorial
{
    public int Id { get; set; }
    public string title { get; set; }
    public string year { get; set; }
    public string Description { get; set; }

    public Tutorial(int id, string title, string year, string description)
    {
        this.Id = id;
        this.title = title;
        this.year = year;
        this.Description = description;
    }
}