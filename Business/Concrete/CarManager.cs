using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(p =>  p.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(p=> p.ColorId == colorId);
        }

        public void PrintTheList()
        {
            List<Car> list = _carDal.GetAll();
            foreach (var car in list) 
            {
                Console.WriteLine("Araç ID:" + car.Id + " || Description: " + car.Description + "|| Price: " + car.DailyPrice);
            }
        }

        public void AddCar (Car car)
        {
            if(car.Description.Length < 2 )
            {
                Console.WriteLine("Araba ismi 2 harften az olamaz");
            }else if(car.DailyPrice <= 0)
            {
                Console.WriteLine("Araba fiyatı 0 dan küçük olamaz");
            }
            else
            {
                _carDal.Add(car);
            }
        }

        public void RemoveCar (Car car)
        {
            _carDal.Delete(car);
        }

        public void UpdateCar(Car car)
        {
            if (car.Description.Length < 2)
            {
                throw new Exception("Araba ismi 2 harften az olamaz");
            }
            else if (car.DailyPrice <= 0)
            {
                throw new Exception("Araba fiyatı 0 dan küçük olamaz");
            }
            else
            {
                _carDal.Update(car);
            }

        }
    }
}
