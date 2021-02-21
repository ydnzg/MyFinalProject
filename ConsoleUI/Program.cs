using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();
            ProductDetailTest();
        }

        private static void ProductDetailTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();

            if (result.Success)

            {

                foreach (var productDetail in result.Data)
                {
                    Console.WriteLine("product id:  " + productDetail.ProductId + "/  " +
                                      "product name:  " + productDetail.ProductName + "/  " +
                                      "category name:  " + productDetail.CategoryName + "/  " +
                                      "units in stock:  " + productDetail.UnitsInStock);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }


        //private static void CategoryTest()
        //{
        //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        //    foreach (var category in categoryManager.GetAll())
        //    {
        //        Console.WriteLine(category.CategoryName);
        //    }
        //}

        //private static void ProductTest()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal());

        //    foreach (var product in productManager.GetByUnitPrice(40, 100).Data)
        //    {
        //        Console.WriteLine(product.ProductName);
        //    }
        //}


    }
}
