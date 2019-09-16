using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Entities;
using Inventory.Exception;

namespace Inventory.DataAccessLayer
{
    public class RawMaterialDAL
    {
        public static List<RawMaterial> rawMaterialList = new List<RawMaterial>();

        public bool AddRawMaterialDAL(RawMaterial newRawMaterial)
        {
            bool rawMaterialAdded = false;
            try
            {
                rawMaterialList.Add(newRawMaterial);
                rawMaterialAdded = true;
            }
            catch (SystemException ex)
            {
                throw new InventoryException(ex.Message);
            }
            return rawMaterialAdded;
        }

        public bool DeleteRawMaterialDAL(string deleteRawMaterialID)
        {
            bool rawMaterialDeleted = false;
            try
            {
                RawMaterial deleteRawMaterial = null;
                foreach (RawMaterial item in rawMaterialList)
                {
                    if (item.RawMaterialID == deleteRawMaterialID)
                    {
                        deleteRawMaterial = item;
                    }
                }

                if (deleteRawMaterial != null)
                {
                    rawMaterialList.Remove(deleteRawMaterial);
                    rawMaterialDeleted = true;
                }
            }
            catch (SystemException ex)
            {
                throw new InventoryException(ex.Message);
            }
            return rawMaterialDeleted;

        }

        public bool UpdateRawMaterialDAL(RawMaterial updateRawMaterial)
        {
            bool rawMaterialUpdated = false;
            try
            {
                foreach (RawMaterial item in rawMaterialList)
                {
                    if (item.RawMaterialID == updateRawMaterial.RawMaterialID)
                    {
                        item.RawMaterialName = updateRawMaterial.RawMaterialName;
                        item.RawMaterialCode = updateRawMaterial.RawMaterialCode;
                        rawMaterialUpdated = true;
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new InventoryException(ex.Message);
            }
            return rawMaterialUpdated;
        }

        public List<RawMaterial> GetAllRawMaterialsDAL()
        {
            return rawMaterialList;
        }

        public RawMaterial SearchRawMaterialByIDDAL(string searchRawMaterialID)
        {
            RawMaterial searchRawMaterial = null;
            try
            {
                foreach (RawMaterial item in rawMaterialList)
                {
                    if (item.RawMaterialID == searchRawMaterialID)
                    {
                        searchRawMaterial = item;
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new InventoryException(ex.Message);
            }
            return searchRawMaterial;
        }

        public RawMaterial SearchRawMaterialByNameDAL(string searchRawMaterialName)
        {
            RawMaterial searchRawMaterial = null;
            try
            {
                foreach (RawMaterial item in rawMaterialList)
                {
                    if (item.RawMaterialName == searchRawMaterialName)
                    {
                        searchRawMaterial = item;
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new InventoryException(ex.Message);
            }
            return searchRawMaterial;
        }

        public RawMaterial SearchRawMaterialByCodeDAL(string searchRawMaterialCode)
        {
            RawMaterial searchRawMaterial = null;
            try
            {
                foreach (RawMaterial item in rawMaterialList)
                {
                    if (item.RawMaterialCode == searchRawMaterialCode)
                    {
                        searchRawMaterial = item;
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new InventoryException(ex.Message);
            }
            return searchRawMaterial;
        }
    }
}
