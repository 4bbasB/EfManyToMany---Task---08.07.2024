namespace EFManyToMany___Task___08._07._2024.Models;

public class Brand
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Model> Models { get; set; } = new List<Model>();
}
