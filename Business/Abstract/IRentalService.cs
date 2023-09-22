using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
  public  interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetById(int entityId);
        IResult Add(Rental entity);
        IResult Update(Rental entity);
        IResult Delete(Rental entity);
        IDataResult<List<RentalDetailDto>> GetRentalDetailDto();
    }
}
