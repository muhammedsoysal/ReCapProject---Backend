using Core.DataAccsess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImage:EfEntityRepositoryBase<CarImage,ReCapProjectContext>,ICarImageDal
    {
        
    }
}