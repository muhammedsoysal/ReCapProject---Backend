using Core.DataAccsess.EntityFramework;
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
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from a in context.Cars
                             join c in context.Colors
                             on a.ColorID equals c.ColorID
                             select new CarDetailDto
                             {
                                 CarID = a.CarID,
                                 CarName = a.CarName,
                                 ColorID = c.ColorID,
                                 ColorName = c.Name,
                                 DailyPrice = a.DailyPrice,
                             };
                return result.ToList();
            }
        }
    }
}
