using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Entities;
using Inventory.DataAccessLayer;
using Inventory.BusinessLayer;
using Inventory.Exception;

namespace Inventory.PresentationLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*RawMaterial rawMaterial1 = new RawMaterial() { RawMaterialID = "RM101", RawMaterialName = "Mango", RawMaterialCode = "MGO" };
            RawMaterial rawMaterial2 = new RawMaterial() { RawMaterialID = "RM102", RawMaterialName = "Banana", RawMaterialCode = "BNN" };
            RawMaterial rawMaterial3 = new RawMaterial() { RawMaterialID = "RM103", RawMaterialName = "Apple", RawMaterialCode = "APP" };
            RawMaterial rawMaterial4 = new RawMaterial() { RawMaterialID = "RM104", RawMaterialName = "Pineapple", RawMaterialCode = "PAP" };
            RawMaterialBL.AddRawMaterialBL(rawMaterial1);
            RawMaterialBL.AddRawMaterialBL(rawMaterial2);
            RawMaterialBL.AddRawMaterialBL(rawMaterial3);
            RawMaterialBL.AddRawMaterialBL(rawMaterial4);
            List<RawMaterial> rawMaterialList = RawMaterialBL.GetAllRawMaterialsBL();
            foreach (RawMaterial item in rawMaterialList)
            {
                Console.WriteLine(item.RawMaterialID + " " + item.RawMaterialName + " " + " " + item.RawMaterialCode);
            }
            Console.WriteLine("******************************************************************");
            Console.WriteLine("\n");

            RawMaterialBL.DeleteRawMaterialBL("RM103");
            RawMaterialBL.DeleteRawMaterialBL("RM104");
            foreach (RawMaterial item in rawMaterialList)
            {
                Console.WriteLine(item.RawMaterialID + " " + item.RawMaterialName + " " + " " + item.RawMaterialCode);
            }
            Console.WriteLine("******************************************************************");
            Console.WriteLine("\n");

            RawMaterial rawMaterial5 = new RawMaterial() { RawMaterialID = "RM101", RawMaterialName = "Mangooo", RawMaterialCode = "MAN" };
            RawMaterialBL.UpdateRawMaterialBL(rawMaterial5);
            foreach (RawMaterial item in rawMaterialList)
            {
                Console.WriteLine(item.RawMaterialID + " " + item.RawMaterialName + " " + " " + item.RawMaterialCode);
            }
            Console.WriteLine("******************************************************************");
            Console.WriteLine("\n");

            RawMaterial rawMaterial6 = RawMaterialBL.SearchRawMaterialByIDBL("RM101");
            Console.WriteLine(rawMaterial6.RawMaterialID + " " + rawMaterial6.RawMaterialName + " " + rawMaterial6.RawMaterialCode + " ");

            RawMaterial rawMaterial7 = RawMaterialBL.SearchRawMaterialByCodeBL("MAN");
            Console.WriteLine(rawMaterial7.RawMaterialID + " " + rawMaterial7.RawMaterialName + " " + rawMaterial7.RawMaterialCode + " ");

            RawMaterial rawMaterial8 = RawMaterialBL.SearchRawMaterialByNameBL("Banana");
            Console.WriteLine(rawMaterial8.RawMaterialID + " " + rawMaterial8.RawMaterialName + " " + rawMaterial8.RawMaterialCode + " ");*/


            Product product1 = new Product() { ProductID = "P101", ProductName = "Mango", ProductCode = "MGO", ProductMFD = "12-09-19", ProductEXP = "12-09-20", ProductType = "mocktail" };
            Product product2 = new Product() { ProductID = "P102", ProductName = "Banana", ProductCode = "BAN", ProductMFD = "12-09-19", ProductEXP = "12-09-20", ProductType = "mocktail" };
            Product product3 = new Product() { ProductID = "P103", ProductName = "Apple", ProductCode = "APP", ProductMFD = "12-09-19", ProductEXP = "12-09-20", ProductType = "mocktail" };
            Product product4 = new Product() { ProductID = "P104", ProductName = "Guava", ProductCode = "GAV", ProductMFD = "12-09-19", ProductEXP = "12-09-20", ProductType = "mocktail" };
            ProductBL.AddProductBL(product1);
            ProductBL.AddProductBL(product2);
            ProductBL.AddProductBL(product3);
            ProductBL.AddProductBL(product4);


            List<Product> productList = ProductBL.GetAllProductsBL();
            foreach (Product item in productList)
            {
                Console.WriteLine(item.ProductID + " " + item.ProductName + " " + item.ProductCode + " " + item.ProductType);
            }
            Console.WriteLine("******************************************************************");
            Console.WriteLine("\n");

            ProductBL.DeleteProductBL("P103");
            ProductBL.DeleteProductBL("P104");
            foreach (Product item in productList)
            {
                Console.WriteLine(item.ProductID + " " + item.ProductName + " " + item.ProductCode + " " + item.ProductType);
            }
            Console.WriteLine("******************************************************************");
            Console.WriteLine("\n");

            Product product5 = new Product() { ProductID = "P101", ProductName = "Mangooo", ProductCode = "MAO", ProductMFD = "12-09-19", ProductEXP = "12-09-20", ProductType = "mocktail" };
            ProductBL.UpdateProductBL(product5);
            foreach (Product item in productList)
            {
                Console.WriteLine(item.ProductID + " " + item.ProductName + " " + item.ProductCode + " " + item.ProductType);
            }
            Console.WriteLine("******************************************************************");
            Console.WriteLine("\n");

            Product product6 = ProductBL.SearchProductByIDBL("P101");
            Console.WriteLine(product6.ProductID + " " + product6.ProductName + " " + product6.ProductCode + " ");

            Product product7 = ProductBL.SearchProductByNameBL("Banana");
            Console.WriteLine(product7.ProductID + " " + product7.ProductName + " " + product7.ProductCode + " ");

            Product product8 = ProductBL.SearchProductByCodeBL("MAO");
            Console.WriteLine(product8.ProductID + " " + product8.ProductName + " " + product8.ProductCode + " ");
        }
    }
}
