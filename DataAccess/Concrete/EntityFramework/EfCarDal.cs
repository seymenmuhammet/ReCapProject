﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, MyDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var result = from b in context.Brands
                             join c in context.Cars on b.Id equals c.BrandId
                             join cl in context.Colors on c.ColorId equals cl.Id
                             select new CarDetailDto 
                             {   CarName = c.Description,
                                 BrandName = b.Name, 
                                 ColorName = cl.Name, 
                                 DailyPrice = c.DailyPrice 
                             };
                return result.ToList();
            }
        }
    }
}
