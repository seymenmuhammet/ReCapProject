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
            CarManager carManager = new CarManager(efCar);

            Car newCar = new Car { Id = 6, BrandId = 6, ColorId = 7, DailyPrice = 600, Description = "6.araba GÜNCELLENDİ", ModelYear = 2026 };
            
            Console.WriteLine("Default car list: -------------------");
            carManager.PrintTheList();

            Console.WriteLine("Adding new cars: -------------------");
            carManager.AddCar(newCar);
            carManager.PrintTheList();

            /*Console.WriteLine("Updating a car: --------------------");
            carManager.UpdateCar(new Car { Id = 6, BrandId = 6, ColorId = 7, DailyPrice = 700, Description = "7.araba", ModelYear = 2026 });
            carManager.PrintTheList();*/

            Console.WriteLine("Remove a car: --------------------");
            carManager.RemoveCar(new Car { Id = 6 });
            carManager.PrintTheList();

            
            //Id si 2 olan araçlar
            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine("Renk id = 2 olan araçlar: " + car.Description);
            }
            Console.WriteLine("-----------------------");
            //Marka id si 1 olan araçlar
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine("Marka id = 1 olan araçlar: " + car.Description);
            }
        }
    }
}