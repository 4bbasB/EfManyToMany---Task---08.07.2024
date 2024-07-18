namespace EFManyToMany___Task___08._07._2024.Models;

public class Model
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int BrandId { get; set; }
    public Brand Brand { get; set; }
    public List<Car> Cars { get; set; } = new List<Car>();
}
