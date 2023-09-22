using Core.DataAccsess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetailDto()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                // equals  ==
                var result = from renta in context.Rentals
                             join custo in context.Customers
                             on renta.CustomerID equals custo.CustomerID

                             join use in context.Users
                             on custo.UserID equals use.UserID

                             join car in context.Cars
                             on renta.CarID equals car.CarID

                             join brand in context.Brands
                             on car.BrandID equals brand.BrandID

                             select new RentalDetailDto
                             {
                                 RentalId = renta.RentalID,
                                 BrandName = brand.Name,
                                 FirstName = use.FirstName,
                                 LastName = use.LastName,
                                 RentDate = renta.RentDate,
                                 ReturnDate = renta.ReturnDate
                             };

                return result.ToList();
            }
        }
    }
}
