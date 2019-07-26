using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeanKellyInventorySystem
{
    class Inhouse : Part
    {       

        public Inhouse(int partID, string name, double price, int inStock, int max, int min, int mID)
            :base(partID, name, price, inStock, max, min)
        {
            MachineID = mID;
        }        

        public int MachineID { get; set; }
    }
}
