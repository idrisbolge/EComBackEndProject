using Core.DataAccess;
using Core.Entities;
using System.Collections.Generic;


namespace Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int SubId { get; set; }
        public List<Category> Children { get; set; }
    }
}
