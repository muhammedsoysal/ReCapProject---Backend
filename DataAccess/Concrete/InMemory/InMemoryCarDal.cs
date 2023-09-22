using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {

            new Car{ CarID = 1 , BrandID = 1, ColorID = 1 , DailyPrice = 50000, ModelYear = 2021, Description = " Sıfır "},
            new Car{ CarID = 2 , BrandID = 1, ColorID = 2 , DailyPrice = 60000, ModelYear = 2019, Description = " 2. El "},
            new Car{ CarID = 3 , BrandID = 2, ColorID = 2 , DailyPrice = 30000, ModelYear = 2008, Description = " 2. El "},
            new Car{ CarID = 4 , BrandID = 3, ColorID = 3 , DailyPrice = 10000, ModelYear = 2019, Description = " Sıfır "},
            new Car{ CarID = 5 , BrandID = 3, ColorID = 4 , DailyPrice = 90000, ModelYear = 2020, Description = " 2. El "}

            };


        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarID == car.CarID);

            _cars.Remove(carToDelete);
        }

        public List<Car> Get()
        {
            throw new NotImplementedException();
        }

        public List<Car> Get(Expression<Func<Car, bool>> filter)
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

        public List<Car> GetById(int car)
        {
            return _cars.Where(c => c.CarID == car).ToList(); // listeleme yapar
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarID == car.CarID);

            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorID = car.ColorID;
            carToUpdate.Description = car.Description;

        }

        Car IEntityRepository<Car>.Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}