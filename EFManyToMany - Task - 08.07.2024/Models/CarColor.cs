namespace EFManyToMany___Task___08._07._2024.Models;

public class CarColor
{
    public int Id { get; set; }
    public int CarId { get; set; }
    public int ColorId { get; set; }    
    public Car Car { get; set; }
    public Color Color { get; set; }
}
