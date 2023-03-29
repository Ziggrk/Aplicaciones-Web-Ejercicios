﻿namespace WebApplication1.Models;


public class Tutorial
{
    public int Id { get; set; }
    public string title { get; set; }
    public int year { get; set; }
    public string Description { get; set; }

    public Category category { get; set; }

    public Tutorial(int id, string title, int year, string description, Category category)
    {
        this.Id = id;
        this.title = title;
        this.year = year;
        this.Description = description;
        this.category = category;
    }
}