namespace EFManyToMany___Task___08._07._2024.Models;

public class Color
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<CarColor> CarColors { get; set; } = new List<CarColor>();
}
