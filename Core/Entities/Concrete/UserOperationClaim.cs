namespace Core.Entities.Concrete
{
    public class UserOperationClaim:IEntity
    {
        public int UserOperationClaimID { get; set; }
        public int UserID { get; set; }
        public int OperationClaimID { get; set; }
    }
}