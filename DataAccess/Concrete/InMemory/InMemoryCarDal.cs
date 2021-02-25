using Data_Access.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Data_Access.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{  Id=1, BrandId=1, ColorId=35, DailyPrice=10, Description="mavi", ModelYear="2020"},
                new Car{  Id=2, BrandId=3, ColorId=34, DailyPrice=20, Description="mor", ModelYear="2020"},
                new Car{  Id=3, BrandId=2, ColorId=33, DailyPrice=30, Description="sarı", ModelYear="2020"},
                new Car{  Id=4, BrandId=4, ColorId=32, DailyPrice=50, Description="kırmızı", ModelYear="2020"}

            };
        }
        public void Add(Car car)
        {

            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carDelete);
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

        public List<Car> GetById(int getById)
        {
            return _cars.Where(p => p.BrandId == getById).ToList();
        }

        public List<CarDetailDTO> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
            carUpdate.ModelYear = car.ModelYear;

        }
    }
}
