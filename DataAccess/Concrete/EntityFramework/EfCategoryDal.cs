using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NortwindContext>, ICategoryDal
    {
        public List<Category> GetCategories()
        {
            using (NortwindContext context = new NortwindContext())
            {
                var result = (from c in context.Categories
                              select new Category{
                                    CategoryId = c.CategoryId,
                                    CategoryName = c.CategoryName,
                                    SubId = c.SubId,
                                    Children = GetChild(c.CategoryId).ToList()
                                } 
                            ).ToList();
            
                return result.ToList();
            }
        }


        private static List<Category> GetChild(int id)
        {
            using (NortwindContext context = new NortwindContext())
            {
                var data = (from c in context.Categories
                            where c.SubId == id
                            select new Category
                            {
                                CategoryId = c.CategoryId,
                                CategoryName = c.CategoryName,
                                SubId = c.SubId
                            }
                            ).ToList();
               
                return data.ToList();
            }
        }
    }
}
