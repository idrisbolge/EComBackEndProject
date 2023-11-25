using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName{ get; set; }
        public int UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public Guid? CoverPhoto { get; set; }
    }
}
