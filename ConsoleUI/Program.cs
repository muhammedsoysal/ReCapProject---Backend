using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarDetails();
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetRentalDetailDto();
            if (result.Success == true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.BrandName + " " + item.RentDate + " " + item.ReturnDate);
                }
                Console.WriteLine(result.Success + "\n" + result.Message);
            }
            else
                Console.WriteLine(result.Success + "\n" + result.Message);

        }
        static void CarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.CarName + " " + item.ColorName + " " + item.DailyPrice);
                }
            else
                Console.WriteLine(result.Success + "\n" + result.Message);
        }
    }
}
