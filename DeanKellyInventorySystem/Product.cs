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
    class Product
    {
        //AssociatedParts BindingList
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        //Instance Variables
        //private int productID;
        //private string name;
        //private double price;
        //private int inStock;
        //private int min;
        //private int max;

        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int InStock { get; set; }        
        public int Min { get; set; }
        public int Max { get; set; }

        public Product() { }
        public Product(int productID, string name, double price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;            
            Min = min;
            Max = max;
        }
        //AddAssociatedPart
        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        //RemoveAssociatedPart
        public bool RemoveAssociatedPart(int partID)
        {
            bool success = false;
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    return success = true;
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }          
        //LookupAssociatedPart
        public Part LookupAssociatedPart(int i)
        {
            for(int j = 0; j < AssociatedParts.Count; j++)
            {
                if(AssociatedParts[j].PartID.Equals(i))
                {
                    return AssociatedParts[j];
                }
            }
            return null;
        }
        public static Part CurrentPart { get; set; }
        public static int CurrentPartID { get; set; }
        public static int CurrentPartIndex { get; set; }
    }
}
