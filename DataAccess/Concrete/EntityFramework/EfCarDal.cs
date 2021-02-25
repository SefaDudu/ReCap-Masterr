using Core.DataAccess.EntityFramework;
using Data_Access.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, NorthwindContext>, ICarDal
    {
        public List<CarDetailDTO> GetCarDetails()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from c in context.Car
                             join b in context.Brand
                             on c.BrandId equals b.Id
                             join color in context.Color
                             on c.ColorId equals color.Id
                             select new CarDetailDTO
                             { CarName = c.Description,
                                 BrandName = b.BrandName,
                                 ColorName = color.ColorName,
                                 DailyPrice = c.DailyPrice


                             };
                return result.ToList();

            }
        }
    }
}
