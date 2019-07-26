
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeanKellyInventorySystem
{
    public partial class MainScreen : Form
    {
        public int Inx { get; set; }

        private void formatDGV(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            d.RowHeadersVisible = false;            
        }
               
        public MainScreen()
        {
            InitializeComponent();
            formatDGV(dataGridViewParts);
            dataGridViewParts.DataSource = Inventory.AllParts;
            formatDGV(dataGridViewProducts);
            dataGridViewProducts.DataSource = Inventory.Products;            
        }
        //
        //Main Screen Part Buttons
        //
        //Part Search Button
        private void buttonPartsSearch_Click(object sender, EventArgs e)
        {
            dataGridViewParts.ClearSelection();
            dataGridViewParts.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            bool found = false;
            if (boxPartSearch.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(boxPartSearch.Text.ToUpper()))
                    {
                        dataGridViewParts.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }
        }
        //Part Add Button
        private void buttonAddPart_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddPart().ShowDialog();
        }
        //Part Modify Button
        private void buttonModifyPart_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (dataGridViewParts.CurrentRow.DataBoundItem.GetType() == typeof(DeanKellyInventorySystem.Inhouse))
            {
                Inhouse inPart = (Inhouse)dataGridViewParts.CurrentRow.DataBoundItem;
                new ModifyPart(inPart).ShowDialog();
            }
            else
            {
                Outsourced outPart = (Outsourced)dataGridViewParts.CurrentRow.DataBoundItem;
                new ModifyPart(outPart).ShowDialog();
            }
        }
        //Part Delete Button
        private void buttonDeletePart_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewParts.SelectedRows)
            {
                dataGridViewParts.Rows.RemoveAt(row.Index);
            }
        }
        //
        //Main Screen Product Buttons
        //
        //Product Search Button
        private void buttonProductsSearch_Click(object sender, EventArgs e)
        {
            dataGridViewProducts.ClearSelection();
            dataGridViewProducts.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            bool found = false;
            if (boxProductSearch.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(boxProductSearch.Text.ToUpper()))
                    {
                        dataGridViewProducts.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }

        }        
        //Product Add Button
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddProduct().ShowDialog();
        }
        //Product Modify Button
        private void buttonModifyProduct_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Product product = (Product)dataGridViewProducts.CurrentRow.DataBoundItem;
            new ModifyProduct(product).ShowDialog();
            
        }
        //Product Delete Button
        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                //Exception
                Product product = (Product)dataGridViewProducts.CurrentRow.DataBoundItem;
                if (product.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot delete a product that has a part assigned to it.");
                    return;
                }
            }
            catch
            {

            }

            foreach (DataGridViewRow row in dataGridViewProducts.SelectedRows)
            {
                dataGridViewProducts.Rows.RemoveAt(row.Index);
            }
            

        }
        //
        //Exit Button
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.CurrentPartID = (int)dataGridViewParts.Rows[e.RowIndex].Cells[0].Value;
        }
    }
}
