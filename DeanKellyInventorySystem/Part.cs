using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeanKellyInventorySystem
{
    abstract class Part
    {
        private int partID;
        private string name;
        private double price;
        private int inStock;
        private int min;
        private int max;

        public Part(int partID, string name, double price, int inStock, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        protected Part(int partID, string name, int inStock, double price, int min, int max)
        {
            this.partID = partID;
            this.name = name;
            this.inStock = inStock;
            this.price = price;
            this.min = min;
            this.max = max;
        }

        public int PartID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        
    }
}
