using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ReCapProjectContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new ReCapProjectContext())
            {
                var result = from operationClaim in context.OperationClaims
                    join userOperationClaim in context.UserOperationClaims
                        on operationClaim.OperationClaimID equals userOperationClaim.UserOperationClaimID
                    where userOperationClaim.UserID == user.UserID
                    select new OperationClaim { OperationClaimID = operationClaim.OperationClaimID, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }


}