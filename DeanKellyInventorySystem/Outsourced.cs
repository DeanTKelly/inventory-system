using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeanKellyInventorySystem
{
    class Outsourced : Part
    {

        public Outsourced(int partID, string name, double price, int inStock, int max, int min, string cName)
            : base(partID, name, price, inStock, max, min)
        {
            CompanyName = cName;
        }       

        public string CompanyName { get; set; }
    }
}
