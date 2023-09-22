using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Rental : IEntity
    {
        public int RentalID { get; set; }
        public int CarID { get; set; }       // BradName
        public int CustomerID { get; set; }  // isim ve soyisim
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
