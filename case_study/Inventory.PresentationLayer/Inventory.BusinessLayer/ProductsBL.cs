using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Entities;
using Inventory.Exception;
using Inventory.DataAccessLayer;
using System.Text.RegularExpressions;

namespace Inventory.BusinessLayer
{    
    public class ProductBL
    {
        private static bool ValidateProduct(Product product)
        {
            StringBuilder sb = new StringBuilder();
            bool validProduct = true;

            foreach (Product item in ProductDAL.productList)
            {
                if (item.ProductID == product.ProductID)
                {
                    validProduct = false;
                    sb.Append("\nProduct ID already exists");
                }
            }
            if (product.ProductID == String.Empty || product.ProductID.Length > 5)
            {
                validProduct = false;
                sb.Append("\nInvalid Product ID");
            }

            Regex regex1 = new Regex("^[a-zA-Z]+$");
            if (!regex1.IsMatch(product.ProductName) || product.ProductName == String.Empty || product.ProductName.Length > 30)
            {
                validProduct = false;
                sb.Append("\nInvalid Product Name");
            }

            foreach (Product item in ProductDAL.productList)
            {
                if (item.ProductCode == product.ProductCode)
                {
                    validProduct = false;
                    sb.Append("\nProduct Code already exists");
                }
            }
            Regex regex2 = new Regex("^[a-zA-Z]+$");
            if (!regex2.IsMatch(product.ProductCode) || product.ProductCode == String.Empty || product.ProductCode.Length > 4)
            {
                validProduct = false;
                sb.Append("\nInvalid Product Code");
            }
            DateTime mfd = Convert.ToDateTime(product.ProductMFD);
            DateTime now = DateTime.Now;
            int res1 = DateTime.Compare(mfd, now);
            if(res1 > 0)
            {
                validProduct = false;
                sb.Append("\nInvalid Manufacture Date");
            }

            DateTime exp = Convert.ToDateTime(product.ProductEXP);
            int res2 = DateTime.Compare(now, exp);
            if (res2 > 0)
            {
                validProduct = false;
                sb.Append("\nInvalid Expiry Date");
            }
            
            /*if(product.ProductType.ToLower() != "juice" || product.ProductType.ToLower() == "energy drink" || product.ProductType.ToLower() == "tonic water" || product.ProductType.ToLower() == "mocktail" || product.ProductType.ToLower() is "softdrink")
            {
                validProduct = false;
                sb.Append("\nInvalid Product Type");
            }*/

            if (validProduct == false)
            {
                throw new InventoryException(sb.ToString());
            }
            return validProduct;
        }

        public static bool AddProductBL(Product newProduct)
        {
            bool productAdded = false;
            try
            {
                if (ValidateProduct(newProduct))
                {
                    ProductDAL productDAL = new ProductDAL();
                    productAdded = productDAL.AddProductDAL(newProduct);
                }
            }
            catch (InventoryException)
            {
                throw;
            }
            catch (SystemException ex)
            {
                throw ex;
            }

            return productAdded;
        }

        public static bool DeleteProductBL(string deleteProductID)
        {
            bool productDeleted = false;
            try
            {
                if (deleteProductID.Length > 0 && deleteProductID.Length < 5)
                {
                    ProductDAL productDAL = new ProductDAL();
                    productDeleted = productDAL.DeleteProductDAL(deleteProductID);
                }
                else
                {
                    throw new InventoryException("Invalid Product ID");
                }

            }
            catch (InventoryException)
            {
                throw;
            }
            catch (SystemException ex)
            {
                throw ex;
            }
            return productDeleted;
        }

        public static bool UpdateProductBL(Product updateProduct)
        {
            bool productUpdated = false;
            try
            {
                if (ValidateProduct(updateProduct))
                {
                    ProductDAL productDAL = new ProductDAL();
                    productUpdated = productDAL.UpdateProductDAL(updateProduct);
                }
            }
            catch (InventoryException)
            {
                throw;
            }
            catch (SystemException ex)
            {
                throw ex;
            }

            return productUpdated;
        }

        public static List<Product> GetAllProductsBL()
        {
            List<Product> productList = null;
            try
            {
                ProductDAL productDAL = new ProductDAL();
                productList = productDAL.GetAllProductsDAL();
            }
            catch (InventoryException ex)
            {
                throw ex;
            }
            catch (SystemException ex)
            {
                throw ex;
            }
            return productList;
        }

        public static Product SearchProductByIDBL(string searchProductID)
        {
            Product searchProduct = null;
            try
            {
                ProductDAL productDAL = new ProductDAL();
                searchProduct = productDAL.SearchProductByIDDAL(searchProductID);
            }
            catch (InventoryException ex)
            {
                throw ex;
            }
            catch (SystemException ex)
            {
                throw ex;
            }
            return searchProduct;
        }

        public static Product SearchProductByNameBL(string searchProductName)
        {
            Product searchProduct = null;
            try
            {
                ProductDAL productDAL = new ProductDAL();
                searchProduct = productDAL.SearchProductByNameDAL(searchProductName);
            }
            catch (InventoryException ex)
            {
                throw ex;
            }
            catch (SystemException ex)
            {
                throw ex;
            }
            return searchProduct;
        }

        public static Product SearchProductByCodeBL(string searchProductCode)
        {
            Product searchProduct = null;
            try
            {
                ProductDAL productDAL = new ProductDAL();
                searchProduct = productDAL.SearchProductByCodeDAL(searchProductCode);
            }
            catch (InventoryException ex)
            {
                throw ex;
            }
            catch (SystemException ex)
            {
                throw ex;
            }
            return searchProduct;
        }
    }
}
