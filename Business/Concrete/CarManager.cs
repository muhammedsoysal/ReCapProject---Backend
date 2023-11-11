using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.BusinessAspects.AutoFac;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.AutoFac.Caching;
using Core.Aspects.AutoFac.Performance;
using Core.Aspects.AutoFac.Transaction;
using Core.Aspects.AutoFac.Validation;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [SecuredOperation("car.add,admin,moderator")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);

        }

        public IResult Delete(Car car)
        {
            //koşullar 
            _carDal.Delete(car);
            return new SuccessResult(Messages.SuccessDeleted);
        }
        [CacheAspect] //key, value
        [PerformanceAspect(100)]
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 18)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour == 18)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }
        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            Add(car);
            if (car.DailyPrice < 500)
                throw new Exception("");

            Add(car);
            return null;
        }

        public IDataResult<List<CarDetailDto>> GetCarsByBrandId(int id)
        {
            var cars = _carDal.GetAll(p => p.BrandID == id).Select(car => new CarDetailDto()).ToList();
            return new SuccessDataResult<List<CarDetailDto>>(cars);
        }

        public IDataResult<List<CarDetailDto>> GetCarsByColorId(int id)
        {
            var cars = _carDal.GetAll(p => p.ColorID == id).Select(car => new CarDetailDto()).ToList();
            return new SuccessDataResult<List<CarDetailDto>>(cars);
        }

        public IResult Update(Car car)
        {
            if (car.CarName.Length <= 2 && car.DailyPrice < 0)
            {
                return new ErrorResult(Messages.CarNameAndPriceInvalid);
            }
            _carDal.Update(car);
            return new SuccessResult(Messages.SuccessUpdated);
        }
    }
}
