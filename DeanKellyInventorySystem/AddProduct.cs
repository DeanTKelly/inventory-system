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
    partial class AddProduct : Form
    {
        private bool allowSave()
        {
            return (!string.IsNullOrWhiteSpace(textBoxAddProductName.Text) && !string.IsNullOrWhiteSpace(textBoxAddProductInv.Text) &&
                !string.IsNullOrWhiteSpace(textBoxAddProductPrice.Text) && !string.IsNullOrWhiteSpace(textBoxAddProductMin.Text) && !string.IsNullOrWhiteSpace(textBoxAddProductMax.Text));
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

        public AddProduct()
        {
            InitializeComponent();
            formatDGV(dataGridViewAddProduct1);
            dataGridViewAddProduct1.DataSource = Inventory.AllParts;
            formatDGV(dataGridViewAddProduct2);
            dataGridViewAddProduct2.DataSource = AddedParts;
        }        
        //Add Product Search Button
        private void buttonAddProductSearch_Click(object sender, EventArgs e)
        {
            dataGridViewAddProduct1.ClearSelection();
            dataGridViewAddProduct1.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            bool found = false;
            if (textBoxAddProductSearch.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(textBoxAddProductSearch.Text.ToUpper()))
                    {
                        dataGridViewAddProduct1.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }
        }
        //Add Product Add Button
        private void buttonAddProductAdd_Click(object sender, EventArgs e)
        {
            Part addedParts = (Part)dataGridViewAddProduct1.CurrentRow.DataBoundItem;
            AddedParts.Add(addedParts);
        }
        //Add Product Delete Button
        private void buttonAddProductDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewAddProduct2.SelectedRows)
            {
                dataGridViewAddProduct2.Rows.RemoveAt(row.Index);
            }
        }
        //Add Product Save Button
        private void buttonAddProductSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Exception
                if (BoxAddProductMax < BoxAddProductMin)
                {
                    MessageBox.Show("Minimum must not exceed maximum");
                    return;
                }
                if (BoxAddProductInv < BoxAddProductMin || BoxAddProductInv > BoxAddProductMax)
                {
                    MessageBox.Show("Inventory must be between minimum and maximum");
                    return;
                }                       
                Product addedProduct = new Product((Inventory.Products.Count + 1), BoxAddProductName, BoxAddProductPrice, BoxAddProductInv, BoxAddProductMin, BoxAddProductMax);
                Inventory.AddProduct(addedProduct);

                foreach (Part newPart in AddedParts)
                {
                    addedProduct.AddAssociatedPart(newPart);
                }
            }
            catch (FormatException formatException)
            {
                MessageBox.Show("Please enter numeric values for Min, Max, Inv, and Price");
            }
            this.Hide();
            new MainScreen().ShowDialog();
        }
        //Add Product Cancel Button
        private void buttonAddProductCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainScreen().ShowDialog();
        }

        private void textBoxAddProductInv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxAddProductInv.Text != "")
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxAddProductMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxAddProductMax.Text != "")
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxAddProductMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxAddProductMin.Text != "")
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxAddProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxAddProductPrice.Text != "")
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
                
        private void textBoxAddProductName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAddProductName.Text))
            {
                textBoxAddProductName.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                textBoxAddProductName.BackColor = System.Drawing.Color.White;
            }
            buttonAddProductSave.Enabled = allowSave();
        }

        private void textBoxAddProductInv_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAddProductInv.Text))
            {
                textBoxAddProductInv.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                textBoxAddProductInv.BackColor = System.Drawing.Color.White;
            }
            buttonAddProductSave.Enabled = allowSave();
        }

        private void textBoxAddProductPrice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAddProductPrice.Text))
            {
                textBoxAddProductPrice.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                textBoxAddProductPrice.BackColor = System.Drawing.Color.White;
            }
            buttonAddProductSave.Enabled = allowSave();
        }

        private void textBoxAddProductMax_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAddProductMax.Text))
            {
                textBoxAddProductMax.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                textBoxAddProductMax.BackColor = System.Drawing.Color.White;
            }
            buttonAddProductSave.Enabled = allowSave();
        }

        private void textBoxAddProductMin_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAddProductMin.Text))
            {
                textBoxAddProductMin.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                textBoxAddProductMin.BackColor = System.Drawing.Color.White;
            }
            buttonAddProductSave.Enabled = allowSave();
        }
    }
}
