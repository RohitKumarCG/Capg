using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Entities
{
    public class RawMaterial
    {
        private string _rawMaterialId;

        public string RawMaterialID
        {
            get { return _rawMaterialId; }
            set { _rawMaterialId = value; }
        }

        private string _rawMaterialName;

        public string RawMaterialName
        {
            get { return _rawMaterialName; }
            set { _rawMaterialName = value; }
        }

        private string _rawMaterialCode;

        public string RawMaterialCode
        {
            get { return _rawMaterialCode; }
            set { _rawMaterialCode = value; }
        }

        public RawMaterial()
        {
            RawMaterialID = string.Empty;
            RawMaterialName = string.Empty;
            RawMaterialCode = string.Empty;
        }
    }
}
