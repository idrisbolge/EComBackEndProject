using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();

            //CategoryTest();

            //ProductDetailTest();


            //string test = "product.add,admin";
            //foreach (var item in test.Split(","))
            //{
            //    Console.WriteLine(item);
            //}

            CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var item in categoryManager.GetAllBySubId().Data)
            {
                Console.WriteLine(item.CategoryName);
            }
            




        }

        private static void ProductTest()
        {/*
            ProductManager productManager = new ProductManager(new EfProductDal());



            foreach (var item in productManager.GetAll().Data)
            {
                Console.WriteLine(item.ProductName);
            }*/
        }
        private static void ProductDetailTest()
        {
            /*ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName + " / " + item.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            */
        }


   
    }
}
