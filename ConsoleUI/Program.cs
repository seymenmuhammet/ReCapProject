using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            EfCarDal efCar = new EfCarDal();
            EfBrandDal efBrand = new EfBrandDal();
            EfColorDal efColor = new EfColorDal();

            CarManager carManager = new CarManager(efCar);
            BrandManager brandManager = new BrandManager(efBrand);
            ColorManager colorManager = new ColorManager(efColor);

            Car newCar = new Car { Id = 6, BrandId = 6, ColorId = 7, DailyPrice = 600, Description = "6.araba GÜNCELLENDİ", ModelYear = 2026 };
            Brand newBrand = new Brand { Id = 5, Name = "Masserati" };
            Color newColor = new Color { Id = 5, Name = "Füme" };

            Console.WriteLine("Default brand list: -------------------");
            brandManager.PrintTheList();
            Console.WriteLine("Default color list: -------------------");
            colorManager.PrintTheList();
            Console.WriteLine("Add brand list: ------------------");
            brandManager.Add(newBrand);
            brandManager.PrintTheList();
            Console.WriteLine("Add color list: ------------------");
            colorManager.Add(newColor);
            colorManager.PrintTheList();
            Console.WriteLine("Update brand list: ---------------");
            brandManager.Update(new Brand { Id = 5 , Name = "Güncel Marka"});
            brandManager.PrintTheList();
            Console.WriteLine("Update color list: ----------------");
            colorManager.Update(new Color { Id = 5, Name = "Güncel Renk" });
            colorManager.PrintTheList();
            Console.WriteLine("Delete brand list: ---------------");
            brandManager.Delete(newBrand);
            brandManager.PrintTheList();
            Console.WriteLine("Delete color list: -----------------");
            colorManager.Delete(newColor);
            colorManager.PrintTheList();


            ProductTest(carManager);


            //DefaultList(carManager);

            //AddNewCar(carManager, newCar);

            //UpdateCar(carManager);

            //RemoveCar(carManager);



        }

        private static void ProductTest(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} - {1} - {2} - {3}", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
            }
        }

        private static void RemoveCar(CarManager carManager)
        {
            Console.WriteLine("Remove a car: --------------------");
            carManager.RemoveCar(new Car { Id = 6 });
            carManager.PrintTheList();
        }

        private static void UpdateCar(CarManager carManager)
        {
            Console.WriteLine("Updating a car: --------------------");
            carManager.UpdateCar(new Car { Id = 6, BrandId = 6, ColorId = 7, DailyPrice = 700, Description = "7.araba", ModelYear = 2026 });
            carManager.PrintTheList();
        }

        private static void AddNewCar(CarManager carManager, Car newCar)
        {
            Console.WriteLine("Adding new cars: -------------------");
            carManager.AddCar(newCar);
            carManager.PrintTheList();
        }

        private static void DefaultList(CarManager carManager)
        {
            Console.WriteLine("Default car list: -------------------");
            carManager.PrintTheList();
        }
    }
}