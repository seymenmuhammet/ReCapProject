using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            EfCarDal efCar = new EfCarDal();
            CarManager carManager = new CarManager(efCar);

            //Id si 2 olan araçlar
            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("-----------------------");
            //Marka id si 1 olan araçlar
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.Description);
            }


        }
    }
}