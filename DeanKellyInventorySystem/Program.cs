using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeanKellyInventorySystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Inventory.AllParts.Add(new Inhouse(1, "Wheel", 12.11, 15, 5, 25, 100));
            Inventory.AllParts.Add(new Inhouse(2, "Pedal", 8.22, 10, 5, 25, 110));
            Inventory.AllParts.Add(new Outsourced(3, "Chain", 8.33, 20, 5, 25, "AMX"));
            Inventory.AllParts.Add(new Outsourced(4, "Seat", 4.55, 12, 2, 15, "Trek"));
            
            Inventory.Products.Add(new Product(1, "Red Bicycle", 89.99, 8, 1, 30));
            Inventory.Products.Add(new Product(2, "Yellow Bicycle", 49.99, 20, 1, 25));
            Inventory.Products.Add(new Product(3, "Blue Bicycle", 89.99, 5, 1, 30));
            Inventory.Products.Add(new Product(4, "Green Bicycle", 59.99, 15, 1, 30));
            Inventory.Products.Add(new Product(5, "Black Bicycle", 99.99, 9, 1, 30));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
    }
}
