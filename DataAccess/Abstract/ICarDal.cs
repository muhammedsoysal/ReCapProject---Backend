using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
   public interface ICarDal:IEntityRepository<Car>
    {
        //// GetById, GetAll, Add, Update, Delete
        //List<Car> GetAll();
        //void Add(Car car);
        //void Delete(Car car);
        //void Update(Car car);
        //List<Car> GetById(int colorID);
        List<CarDetailDto> GetCarDetails();
    }
}
