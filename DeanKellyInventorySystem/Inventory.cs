using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeanKellyInventorySystem
{
    class Inventory
    {
        //BindingLists
        //
        //Products BindingList
        private static BindingList<Product> products = new BindingList<Product>();
        public static BindingList<Product> Products { get { return products; } set { products = value; } }
        //
        //AllParts BindingList
        private static BindingList<Part> allParts = new BindingList<Part>();
        public static BindingList<Part> AllParts { get { return allParts; } set { allParts = value; } }
        //
        //Products
        //
        //AddProduct
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }
        //RemoveProduct
        public bool RemoveProduct(int productID)
        {
            bool success = false;
            foreach (Product prod in Products)
            {
                if (productID == prod.ProductID)
                {
                    Products.Remove(prod);
                    return success = true;
                }
                else
                {
                    MessageBox.Show("Removal failed.");
                    return false;
                }
            }
            return success;
        }
        //LookupProduct
        public static Product LookupProduct(int i)
        {
            for (int j = 0; j < Products.Count; j++)
            {
                if (Products[j].ProductID.Equals(i))
                {
                    CurrentProductIndex = j;
                    return Products[j];
                }
            }
            return null;
        }
        //UpdateProduct
        public static void UpdateProduct(int productID, Product updatedProduct)
        {
            foreach (Product currentProd in Products)
            {
                if (currentProd.ProductID == productID)
                {
                    currentProd.Name = updatedProduct.Name;
                    currentProd.InStock = updatedProduct.InStock;
                    currentProd.Price = updatedProduct.Price;
                    currentProd.Min = updatedProduct.Min;
                    currentProd.Max = updatedProduct.Max;
                    currentProd.AssociatedParts = updatedProduct.AssociatedParts;
                    return;
                }
            }
        }
        //Product Constructors
        public static Product CurrentProduct { get; set; }
        public static int CurrentProductID { get; set; }
        public static int CurrentProductIndex { get; set; }
        //
        //Parts
        //
        //AddPart
        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }
        //DeletePart
        public bool DeletePart(int i)
        {
            bool success = false;
            for (int j = 0; j < AllParts.Count; j++)
            {
                if (AllParts[j].PartID.Equals(i))
                {
                    AllParts.RemoveAt(CurrentPartIndex);
                    return success = true;
                }
                else
                {
                    MessageBox.Show("Removal failed.");
                    return false;
                }
            }
            return success;
        }
        //LookupPart
        public static Part LookupPart(int i)
        {
            for (int j = 0; j < AllParts.Count; j++)
            {
                if (AllParts[j].PartID.Equals(i))
                {
                    return AllParts[j];
                }
            }
            return null;
        }
        //UpdatePart
        //public static void UpdatePart(Part part)
        //{

        //    AllParts.RemoveAt(CurrentPartID);
        //    AllParts.Insert(CurrentPartID, part);
        //}
        public static void UpdateInHouse(int partID, Inhouse inPart)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].GetType() == typeof(DeanKellyInventorySystem.Inhouse))
                {
                    Inhouse newPart = (Inhouse)AllParts[i];

                    if (newPart.PartID == partID)
                    {
                        newPart.Name = inPart.Name;
                        newPart.InStock = inPart.InStock;
                        newPart.Price = inPart.Price;
                        newPart.Min = inPart.Min;
                        newPart.Max = inPart.Max;
                        newPart.MachineID = inPart.MachineID;
                    }
                }
            }
        }
        public static void UpdateOutsourced(int partID, Outsourced outPart)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].GetType() == typeof(DeanKellyInventorySystem.Outsourced))
                {
                    Outsourced newPart = (Outsourced)AllParts[i];

                    if (newPart.PartID == partID)
                    {
                        newPart.Name = outPart.Name;
                        newPart.InStock = outPart.InStock;
                        newPart.Price = outPart.Price;
                        newPart.Min = outPart.Min;
                        newPart.Max = outPart.Max;
                        newPart.CompanyName = outPart.CompanyName;
                    }
                }
            }
        }
        //Part Constructors      
        public static Part CurrentPart { get; set; }
        public static int CurrentPartID { get; set; }
        public static int CurrentPartIndex { get; set; }                                                                                                              
    }          
}
