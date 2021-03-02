using Business.Concrete;
using Data_Access.Abstract;
using Data_Access.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarService();
            //BrandTest();
            //ColorTest();
            //RentalTest();
            //ListCustomer();
            //UserList();
           // RentalList();
            //RentalAdd();
        }

        private static void RentalAdd()
        {
            var date1 = new DateTime(2021, 3, 1, 7, 0, 0);
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { CarId = 3, CustomerId = 1, RentDate = date1, ReturnDate = date1 });
        }

        private static void RentalList()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetAll();
            foreach (var rental in result.Data)
            {
                Console.WriteLine("{0} - {1}  ", rental.RentDate, rental.CarId);
            }
        }

        //private static void UserList()
        //{
        //    UserManager userManager = new UserManager(new EfUserDal());
        //    var result = userManager.GetAll();
        //    foreach (var user in result.Data)
        //    {
        //        Console.WriteLine(user.FirstName);
        //    }
        //}

        private static void ListCustomer()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.CompanyName);
            }
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental {Id=3, CustomerId = 2, CarId = 3, RentDate = new DateTime(2020, 02, 10) });
        }

        //private static void ColorTest()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    foreach (var color in colorManager.GetAll())
        //    {
        //        Console.WriteLine(color.ColorName);

        //    }
        //}

        //private static void BrandTest()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    foreach (var brand in brandManager.GetAll())
        //    {
        //        Console.WriteLine(brand.BrandName);
        //    }
        //}

        private static void CarService()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var join in result.Data)
                {
                    Console.WriteLine(join.CarName + "/" + join.BrandName + " /" + join.ColorName + " /" + join.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

           
            //carManager.Add(new Car { BrandId = 2, ColorId = 3, DailyPrice = 400, ModelYear = "2021", Description = "araba4" });
            //carManager.Add(new Car { BrandId = 2, ColorId = 1, DailyPrice = 0, ModelYear = "2021", Description = "araba4" });
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}
        }
    }
}
