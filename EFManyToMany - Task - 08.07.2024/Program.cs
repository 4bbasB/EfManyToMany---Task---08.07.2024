using EFManyToMany___Task___08._07._2024.DAL;
using EFManyToMany___Task___08._07._2024.Models;

namespace EFManyToMany___Task___08._07._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CreatingBrands
            //var brand1 = new Brand() { Name = "Bentley" };
            //var brand2 = new Brand() { Name = "Lamborghini" };
            //var brand3 = new Brand() { Name = "Mercedes" };
            //Create(brand1);
            //Create(brand2);
            //Create(brand3);
            #endregion

            #region CreatingModels
            //var model1 = new Model() { Name = "Bentayga", BrandId = 1 };
            //var model2 = new Model() { Name = "Continental GT Speed", BrandId = 1 };
            //var model3 = new Model() { Name = "Huracan", BrandId = 2 };
            //var model4 = new Model() { Name = "Revuelto", BrandId = 2 };
            //var model5 = new Model() { Name = "E-Class Coupé", BrandId = 3 };
            //var model6 = new Model() { Name = "G-Class", BrandId = 3 };

            //Create(model1);
            //Create(model2);
            //Create(model3);
            //Create(model4);
            //Create(model5);
            //Create(model6);
            #endregion

            #region CreatingColors
            //var color1 = new Color() { Name = "Black" };
            //var color2 = new Color() { Name = "White" };
            //var color3 = new Color() { Name = "Yellow" };
            //var color4 = new Color() { Name = "Blue" };

            //Create(color1);
            //Create(color2);
            //Create(color3);
            //Create(color4);
            #endregion

            #region CreatingCars
            //var car1 = new Car() { Power = 542, MaxSpeed = 306, FuelTankCapacity = 85, DoorCount = 4, ModelId = 1 };
            //var car2 = new Car() { Power = 650, MaxSpeed = 335, FuelTankCapacity = 90, DoorCount = 2, ModelId = 1 };
            //var car3 = new Car() { Power = 602, MaxSpeed = 325, FuelTankCapacity = 90, DoorCount = 4, ModelId = 2 };
            //var car4 = new Car() { Power = 814, MaxSpeed = 350, FuelTankCapacity = 90, DoorCount = 2, ModelId = 2 };
            //var car5 = new Car() { Power = 375, MaxSpeed = 250, FuelTankCapacity = 66, DoorCount = 4, ModelId = 3 };
            //var car6 = new Car() { Power = 443, MaxSpeed = 180, FuelTankCapacity = 100, DoorCount = 4, ModelId = 3 };

            //Create(car1);
            //Create(car2);
            //Create(car3);
            //Create(car4);
            //Create(car5);
            //Create(car6);
            #endregion

            #region GetById
            //Console.WriteLine(GetBrandById(1).Name);
            //Console.WriteLine(GetModelById(1).Name);
            //Console.WriteLine(GetColorById(1).Name);
            //Console.WriteLine(GetCarById(1).Power);
            #endregion

            #region GetAll
            //var list1 = GetAllBrands();
            //var list2 = GetAllModels();
            //var list3 = GetAllColors();
            //var list4 = GetAllCars();

            //foreach (var item in list1)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //foreach (var item in list3)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //foreach (var item in list4)
            //{
            //    Console.WriteLine(item.Power);
            //}
            #endregion

            #region Update
            //Brand brand = new Brand() { Name = "Lambo" };
            //Update(brand, 2);

            //Model model = new Model() { Name = "E-Class", BrandId = 3 };
            //Update(model, 5);

            //Color color = new Color() { Name = "Red" };
            //Update(color, 3);

            //Car car = new Car() { Power = 375, MaxSpeed = 255, FuelTankCapacity = 65, DoorCount = 2, ModelId = 3 };
            //Update(car, 5);
            #endregion

            #region Delete
            //DeleteBrand(1);
            //DeleteModel(1);
            //DeleteColor(1);
            //DeleteCar(1);
            #endregion

        }



        #region Create
        static void Create(Brand brand)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Brands.Add(brand);
                context.SaveChanges();
            }
        }


        static void Create(Model model)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Models.Add(model);
                context.SaveChanges();
            }
        }

        static void Create(Color color)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Colors.Add(color);
                context.SaveChanges();
            }
        }


        static void Create(Car car)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Cars.Add(car);
                context.SaveChanges();
            }
        }
        #endregion Create


        #region GetById
        static Brand GetBrandById(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var exist = context.Brands.Find(id);
                if (exist == null)
                    throw new NullReferenceException();
                return context.Brands.Find(id);
            }
        }

        static Model GetModelById(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var exist = context.Models.Find(id);
                if (exist == null)
                    throw new NullReferenceException();
                return context.Models.Find(id);
            }
        }

        static Color GetColorById(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var exist = context.Colors.Find(id);
                if (exist == null)
                    throw new NullReferenceException();
                return context.Colors.Find(id);
            }
        }


        static Car GetCarById(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var exist = context.Cars.Find(id);
                if (exist == null)
                    throw new NullReferenceException();
                return context.Cars.Find(id);
            }
        }

        #endregion GetById


        #region GetAll
        static List<Brand> GetAllBrands()
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Brands.ToList();
            }
        }

        static List<Model> GetAllModels()
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Models.ToList();
            }
        }

        static List<Color> GetAllColors()
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Colors.ToList();
            }
        }

        static List<Car> GetAllCars()
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Cars.ToList();
            }
        }


        #endregion GetAll


        #region Update
        static void Update(Brand brand, int BrandId)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var exist = context.Brands.Find(BrandId);
                if (exist != null)
                {
                    exist.Name = brand.Name;
                    context.SaveChanges();
                }
            }
        }

        static void Update(Model model, int ModelId)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var exist = context.Models.Find(ModelId);
                if (exist != null)
                {
                    exist.Name = model.Name;
                    context.SaveChanges();
                }
            }
        }

        static void Update(Color color, int ColorId)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var exist = context.Colors.Find(ColorId);
                if (exist != null)
                {
                    exist.Name = color.Name;
                    context.SaveChanges();
                }
            }
        }

        static void Update(Car car, int CarId)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var exist = context.Cars.Find(CarId);
                if (exist != null)
                {
                    exist.Power = car.Power;
                    exist.FuelTankCapacity = car.FuelTankCapacity;
                    exist.MaxSpeed = car.MaxSpeed;
                    exist.DoorCount = car.DoorCount;
                    context.SaveChanges();
                }
            }
        }

        #endregion Update


        #region Delete
        static void DeleteBrand(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var exist = context.Brands.Find(id);
                if (exist != null)
                {
                    context.Brands.Remove(exist);
                    context.SaveChanges();
                }
            }
        }


        static void DeleteModel(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var exist = context.Models.Find(id);
                if (exist != null)
                {
                    context.Models.Remove(exist);
                    context.SaveChanges();
                }
            }
        }


        static void DeleteColor(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var exist = context.Colors.Find(id);
                if (exist != null)
                {
                    context.Colors.Remove(exist);
                    context.SaveChanges();
                }
            }
        }


        static void DeleteCar(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var exist = context.Cars.Find(id);
                if (exist != null)
                {
                    context.Cars.Remove(exist);
                    context.SaveChanges();
                }
            }
        }

        #endregion Delete















    }
}
