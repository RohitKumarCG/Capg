using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Entities
{
    public class Product
    {
        private string _productId;

        public string ProductID
        {
            get { return _productId; }
            set { _productId = value; }
        }

        private string _productName;

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        private string _productCode;

        public string ProductCode
        {
            get { return _productCode; }
            set { _productCode = value; }
        }

        private string _productMFD;

        public string ProductMFD
        {
            get { return _productMFD; }
            set { _productMFD = value; }
        }

        private string _productEXP;

        public string ProductEXP
        {
            get { return _productEXP; }
            set { _productEXP = value; }
        }

        private string _productType;

        public string ProductType
        {
            get { return _productType; }
            set { _productType = value; }
        }

        public Product()
        {
            ProductID = string.Empty;
            ProductName = string.Empty;
            ProductCode = string.Empty;
            ProductMFD = string.Empty;
            ProductEXP = string.Empty;
            ProductType = string.Empty;
        }
    }
}
