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
    partial class ModifyProduct : Form
    {
        private bool allowSave()
        {
            return (!string.IsNullOrWhiteSpace(textBoxModifyProductName.Text) && !string.IsNullOrWhiteSpace(textBoxModifyProductInv.Text) &&
                !string.IsNullOrWhiteSpace(textBoxModifyProductPrice.Text) && !string.IsNullOrWhiteSpace(textBoxModifyProductMin.Text) && !string.IsNullOrWhiteSpace(textBoxModifyProductMax.Text));
        }

        private static BindingList<Part> addedParts = new BindingList<Part>();
        public static BindingList<Part> AddedParts { get { return addedParts; } set { addedParts = value; } }

        private void formatDGV(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            d.RowHeadersVisible = false;
        }

        public ModifyProduct(Product product)
        {
            InitializeComponent();
            formatDGV(dataGridViewModifyProduct1);
            dataGridViewModifyProduct1.DataSource = Inventory.AllParts;            
            formatDGV(dataGridViewModifyProduct2);
            dataGridViewModifyProduct2.DataSource = AddedParts;

            BoxModifyProductID = product.ProductID;
            BoxModifyProductName = product.Name;
            BoxModifyProductInv = product.InStock;
            BoxModifyProductPrice = product.Price;
            BoxModifyProductMax = product.Max;
            BoxModifyProductMin = product.Min;
        }
               

        private void buttonModifyProductSearch_Click(object sender, EventArgs e)
        {
            dataGridViewModifyProduct1.ClearSelection();
            dataGridViewModifyProduct1.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            bool found = false;
            if (textBoxModifyProductSearch.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(textBoxModifyProductSearch.Text.ToUpper()))
                    {
                        dataGridViewModifyProduct1.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }
        }
        
        private void buttonModifyProductAdd_Click(object sender, EventArgs e)
        {
            Part addedParts = (Part)dataGridViewModifyProduct1.CurrentRow.DataBoundItem;
            AddedParts.Add(addedParts);
        }

        private void buttonModifyProductDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewModifyProduct2.SelectedRows)
            {
                dataGridViewModifyProduct2.Rows.RemoveAt(row.Index);
            }
        }

        private void buttonModifyProductSave_Click(object sender, EventArgs e)
        {
            //Exception
            if (BoxModifyProductMax < BoxModifyProductMin)
            {
                MessageBox.Show("Minimum must not exceed maximum");
                return;
            }
            if (BoxModifyProductInv < BoxModifyProductMin || BoxModifyProductInv > BoxModifyProductMax)
            {
                MessageBox.Show("Inventory must be between minimum and maximum");
                return;
            }
            Product updatedProduct = new Product(BoxModifyProductID, BoxModifyProductName, BoxModifyProductPrice, BoxModifyProductInv, BoxModifyProductMin, BoxModifyProductMax);

            foreach (Part newPart in addedParts)
            {
                updatedProduct.AddAssociatedPart(newPart);
            }

            Inventory.UpdateProduct(BoxModifyProductID, updatedProduct);
            this.Hide();
            new MainScreen().ShowDialog();            
        }

        private void buttonModifyProductCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen f1 = new MainScreen();
            f1.Show();
        }

        private void textBoxModifyProductInv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxModifyProductMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxModifyProductMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxModifyProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }        

        private void textBoxModifyProductName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxModifyProductName.Text))
            {
                textBoxModifyProductName.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                textBoxModifyProductName.BackColor = System.Drawing.Color.White;
            }
            buttonModifyProductSave.Enabled = allowSave();
        }

        private void textBoxModifyProductInv_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxModifyProductInv.Text))
            {
                textBoxModifyProductInv.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                textBoxModifyProductInv.BackColor = System.Drawing.Color.White;
            }
            buttonModifyProductSave.Enabled = allowSave();
        }

        private void textBoxModifyProductPrice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxModifyProductPrice.Text))
            {
                textBoxModifyProductPrice.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                textBoxModifyProductPrice.BackColor = System.Drawing.Color.White;
            }
            buttonModifyProductSave.Enabled = allowSave();
        }

        private void textBoxModifyProductMax_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxModifyProductMax.Text))
            {
                textBoxModifyProductMax.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                textBoxModifyProductMax.BackColor = System.Drawing.Color.White;
            }
            buttonModifyProductSave.Enabled = allowSave();
        }

        private void textBoxModifyProductMin_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxModifyProductMin.Text))
            {
                textBoxModifyProductMin.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                textBoxModifyProductMin.BackColor = System.Drawing.Color.White;
            }
            buttonModifyProductSave.Enabled = allowSave();
        }
    }
}
