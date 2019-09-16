using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Entities;
using Inventory.Exception;

namespace Inventory.DataAccessLayer
{
    public class ProductDAL
    {
        public static List<Product> productList = new List<Product>();

        public bool AddProductDAL(Product newProduct)
        {
            bool productAdded = false;
            try
            {
                productList.Add(newProduct);
                productAdded = true;
            }
            catch (SystemException ex)
            {
                throw new InventoryException(ex.Message);
            }
            return productAdded;
        }

        public bool DeleteProductDAL(string deleteProductID)
        {
            bool productDeleted = false;
            try
            {
                Product deleteProduct = null;
                foreach (Product item in productList)
                {
                    if (item.ProductID == deleteProductID)
                    {
                        deleteProduct = item;
                    }
                }

                if (deleteProduct != null)
                {
                    productList.Remove(deleteProduct);
                    productDeleted = true;
                }
            }
            catch (SystemException ex)
            {
                throw new InventoryException(ex.Message);
            }
            return productDeleted;

        }

        public bool UpdateProductDAL(Product updateProduct)
        {
            bool productUpdated = false;
            try
            {
                foreach (Product item in productList)
                {
                    if (item.ProductID == updateProduct.ProductID)
                    {
                        item.ProductName = updateProduct.ProductName;
                        item.ProductCode = updateProduct.ProductCode;
                        productUpdated = true;
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new InventoryException(ex.Message);
            }
            return productUpdated;

        }

        public List<Product> GetAllProductsDAL()
        {
            return productList;
        }

        public Product SearchProductByIDDAL(string searchProductID)
        {
            Product searchProduct = null;
            try
            {
                foreach (Product item in productList)
                {
                    if (item.ProductID == searchProductID)
                    {
                        searchProduct = item;
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new InventoryException(ex.Message);
            }
            return searchProduct;
        }

        public Product SearchProductByNameDAL(string searchProductName)
        {
            Product searchProduct = null;
            try
            {
                foreach (Product item in productList)
                {
                    if (item.ProductName == searchProductName)
                    {
                        searchProduct = item;
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new InventoryException(ex.Message);
            }
            return searchProduct;
        }

        public Product SearchProductByCodeDAL(string searchProductCode)
        {
            Product searchProduct = null;
            try
            {
                foreach (Product item in productList)
                {
                    if (item.ProductCode == searchProductCode)
                    {
                        searchProduct = item;
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new InventoryException(ex.Message);
            }
            return searchProduct;
        }
    }
}
