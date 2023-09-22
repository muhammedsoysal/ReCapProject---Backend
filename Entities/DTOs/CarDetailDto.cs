using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        public int CarID { get; set; }
        public string CarName { get; set; }
        public Decimal DailyPrice { get; set; }
        public int ColorID { get; set; }
        public string ColorName { get; set; }
        public string BrandName { get; set; }
    }
}
