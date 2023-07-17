using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars = new List<Car>();
        public InMemoryCarDal() 
        {
            _cars = new List<Car> 
            {
                new Car {Id = 1, BrandId = 1 , ColorId = 1, ModelYear = 1990, DailyPrice = 1000 , Description = "Wolkswagen"},
                new Car {Id = 2, BrandId = 2 , ColorId = 2, ModelYear = 1980, DailyPrice = 1000 , Description = "Ford"},
                new Car {Id = 3, BrandId = 3 , ColorId = 3, ModelYear = 1970, DailyPrice = 1000 , Description = "Chevrolet"},
                new Car {Id = 4, BrandId = 4 , ColorId = 4, ModelYear = 1960, DailyPrice = 1000 , Description = "Opel"},
                new Car {Id = 5, BrandId = 5 , ColorId = 5, ModelYear = 1950, DailyPrice = 1000 , Description = "Ferrari"},
            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deleteCar = _cars.SingleOrDefault(p =>  p.Id == car.Id);
            _cars.Remove(deleteCar);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car updatedCar = _cars.SingleOrDefault(p => p.Id == car.Id);
            updatedCar.BrandId = car.BrandId;
            updatedCar.ColorId = car.ColorId;
            updatedCar.DailyPrice = car.DailyPrice;
            updatedCar.Description = car.Description;
            updatedCar.ModelYear = car.ModelYear;            
        }
    }
}
