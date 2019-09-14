using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Entities;
using Inventory.DataAccessLayer;
using System.Text.RegularExpressions;
using Inventory.Exception;

namespace Inventory.BusinessLayer
{
    public class RawMaterialBL
    {
        private static bool ValidateRawMaterial(RawMaterial rawMaterial)
        {
            StringBuilder sb = new StringBuilder();
            bool validRawMaterial = true;

            foreach (RawMaterial item in RawMaterialDAL.rawMaterialList)
            {
                if (item.RawMaterialID == rawMaterial.RawMaterialID)
                {
                    validRawMaterial = false;
                    sb.Append("\nRaw Material ID already exists");
                }
            }
            if (rawMaterial.RawMaterialID == String.Empty || rawMaterial.RawMaterialID.Length > 5)
            {
                validRawMaterial = false;
                sb.Append("\nInvalid Raw Material ID");
            }

            Regex regex1 = new Regex("^[a-zA-Z]+$");
            if (!regex1.IsMatch(rawMaterial.RawMaterialName) || rawMaterial.RawMaterialName == String.Empty || rawMaterial.RawMaterialName.Length > 30)
            {
                validRawMaterial = false;
                sb.Append("\nInvalid Raw Material Name");
            }

            foreach (RawMaterial item in RawMaterialDAL.rawMaterialList)
            {
                if (item.RawMaterialCode == rawMaterial.RawMaterialCode)
                {
                    validRawMaterial = false;
                    sb.Append("\nRaw Material Code already exists");
                }
            }
            Regex regex2 = new Regex("^[a-zA-Z]+$");
            if (!regex2.IsMatch(rawMaterial.RawMaterialName) || rawMaterial.RawMaterialCode == String.Empty || rawMaterial.RawMaterialCode.Length > 4)
            {
                validRawMaterial = false;
                sb.Append("\nInvalid Raw Material Code");
            }

            if (validRawMaterial == false)
            {
                throw new InventoryException(sb.ToString());
            }
            return validRawMaterial;
        }

        public static bool AddRawMaterialBL(RawMaterial newRawMaterial)
        {
            bool rawMaterialAdded = false;
            try
            {
                if (ValidateRawMaterial(newRawMaterial))
                {
                    RawMaterialDAL rawMaterialDAL = new RawMaterialDAL();
                    rawMaterialAdded = rawMaterialDAL.AddRawMaterialDAL(newRawMaterial);
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

            return rawMaterialAdded;
        }

        public static bool DeleteRawMaterialBL(string deleteRawMaterialID)
        {
            bool rawMaterialDeleted = false;
            try
            {
                if (deleteRawMaterialID.Length > 0 && deleteRawMaterialID.Length < 5)
                {
                    RawMaterialDAL rawMaterialDAL = new RawMaterialDAL();
                    rawMaterialDeleted = rawMaterialDAL.DeleteRawMaterialDAL(deleteRawMaterialID);
                }
                else
                {
                    throw new InventoryException("Invalid Raw Material ID");
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
            return rawMaterialDeleted;
        }

        public static bool UpdateRawMaterialBL(RawMaterial updateRawMaterial)
        {
            bool rawMaterialUpdated = false;
            try
            {
                if (ValidateRawMaterial(updateRawMaterial))
                {
                    RawMaterialDAL rawMaterialDAL = new RawMaterialDAL();
                    rawMaterialUpdated = RawMaterialDAL.UpdateRawMaterialDAL(updateRawMaterial);
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

            return rawMaterialUpdated;
        }

        public static List<RawMaterial> GetAllRawMaterialsBL()
        {
            List<RawMaterial> rawMaterialList = null;
            try
            {
                RawMaterialDAL rawMaterialDAL = new RawMaterialDAL();
                rawMaterialList = rawMaterialDAL.GetAllRawMaterialsDAL();
            }
            catch (InventoryException ex)
            {
                throw ex;
            }
            catch (SystemException ex)
            {
                throw ex;
            }
            return rawMaterialList;
        }

        public static RawMaterial SearchRawMaterialByIDBL(string searchRawMaterialID)
        {
            RawMaterial searchRawMaterial = null;
            try
            {
                RawMaterialDAL rawMaterialDAL = new RawMaterialDAL();
                searchRawMaterial = rawMaterialDAL.SearchRawMaterialByIDDAL(searchRawMaterialID);
            }
            catch (InventoryException ex)
            {
                throw ex;
            }
            catch (SystemException ex)
            {
                throw ex;
            }
            return searchRawMaterial;
        }

        public static RawMaterial SearchRawMaterialByNameBL(string searchRawMaterialName)
        {
            RawMaterial searchRawMaterial = null;
            try
            {
                RawMaterialDAL rawMaterialDAL = new RawMaterialDAL();
                searchRawMaterial = rawMaterialDAL.SearchRawMaterialByNameDAL(searchRawMaterialName);
            }
            catch (InventoryException ex)
            {
                throw ex;
            }
            catch (SystemException ex)
            {
                throw ex;
            }
            return searchRawMaterial;
        }

        public static RawMaterial SearchRawMaterialByCodeBL(string searchRawMaterialCode)
        {
            RawMaterial searchRawMaterial = null;
            try
            {
                RawMaterialDAL rawMaterialDAL = new RawMaterialDAL();
                searchRawMaterial = rawMaterialDAL.SearchRawMaterialByCodeDAL(searchRawMaterialCode);
            }
            catch (InventoryException ex)
            {
                throw ex;
            }
            catch (SystemException ex)
            {
                throw ex;
            }
            return searchRawMaterial;
        }
    }
}