using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class CarImage:IEntity
    {
        public int ID { get; set; }
        public int CarID { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}