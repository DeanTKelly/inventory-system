
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
    partial class ModifyPart : Form
    {
        bool isInHouse;

        private bool allowSave()
        {
            int number;
            return (!string.IsNullOrWhiteSpace(BoxModifyPartName.Text) && !string.IsNullOrWhiteSpace(BoxModifyPartInv.Text) &&
                !string.IsNullOrWhiteSpace(BoxModifyPartPriceCost.Text) && !string.IsNullOrWhiteSpace(BoxModifyPartMin.Text) && !string.IsNullOrWhiteSpace(BoxModifyPartMax.Text)) &&
                (!(string.IsNullOrWhiteSpace(BoxModifyPartMachineID.Text) || (isInHouse && !Int32.TryParse(BoxModifyPartMachineID.Text, out number))));
        }

        private void checkOnRBSwitch()
        {
            int number;
            if (string.IsNullOrWhiteSpace(BoxModifyPartMachineID.Text) || (isInHouse && !Int32.TryParse(BoxModifyPartMachineID.Text, out number)))
            {
                BoxModifyPartMachineID.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                BoxModifyPartMachineID.BackColor = System.Drawing.Color.White;
            }
            buttonModifyPartSave.Enabled = allowSave();
        }

        public ModifyPart(Inhouse inPart)
        {
            InitializeComponent();

            textBoxModifyPartID = inPart.PartID;
            textBoxModifyPartName = inPart.Name;
            textBoxModifyPartInv = inPart.InStock;
            textBoxModifyPartPriceCost = inPart.Price;
            textBoxModifyPartMax = inPart.Max;
            textBoxModifyPartMin = inPart.Min;
            textBoxModifyPartMachineID = inPart.MachineID.ToString();            
        }
        
        public ModifyPart(Outsourced outPart)
        {
            InitializeComponent();

            textBoxModifyPartID = outPart.PartID;
            textBoxModifyPartName = outPart.Name;
            textBoxModifyPartInv = outPart.InStock;
            textBoxModifyPartPriceCost = outPart.Price;
            textBoxModifyPartMax = outPart.Max;
            textBoxModifyPartMin = outPart.Min;
            textBoxModifyPartMachineID = outPart.CompanyName;

            radioModifyPartOutsourced.Checked = true;
        }
        //InHouse Radio Button
        private void radioModifyPartInHouse_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Machine ID";
            checkOnRBSwitch();
        }
        //Outsourced Radio Button
        private void radioModifyPartOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Company Name";
            checkOnRBSwitch();
        }        
        //Save Button
        private void buttonModifyPartSave_Click(object sender, EventArgs e)
        {
            //Exception
            if (textBoxModifyPartMax < textBoxModifyPartMin)
            {
                MessageBox.Show("Minimum must not exceed maximum");
                return;
            }
            if (textBoxModifyPartInv < textBoxModifyPartMin || textBoxModifyPartInv > textBoxModifyPartMax)
            {
                MessageBox.Show("Inventory must be between minimum and maximum");
                return;
            }
            if (radioModifyPartInHouse.Checked)
            {
                Inhouse inhouse = new Inhouse(Convert.ToInt32(BoxModifyPartID.Text), BoxModifyPartName.Text, Convert.ToDouble(BoxModifyPartPriceCost.Text),
                                        Convert.ToInt32(BoxModifyPartInv.Text), Convert.ToInt32(BoxModifyPartMin.Text), Convert.ToInt32(BoxModifyPartMax.Text),
                                        Convert.ToInt32(BoxModifyPartMachineID.Text));
                Inventory.UpdateInHouse(Convert.ToInt32(BoxModifyPartID.Text), inhouse);
                radioModifyPartInHouse.Checked = true;
            }
            else
            {
                Outsourced outsourced = new Outsourced(Convert.ToInt32(BoxModifyPartID.Text), BoxModifyPartName.Text, Convert.ToDouble(BoxModifyPartPriceCost.Text),
                                        Convert.ToInt32(BoxModifyPartInv.Text), Convert.ToInt32(BoxModifyPartMin.Text), Convert.ToInt32(BoxModifyPartMax.Text),
                                        BoxModifyPartMachineID.Text);
                Inventory.UpdateOutsourced(Convert.ToInt32(BoxModifyPartID.Text), outsourced);
                radioModifyPartOutsourced.Checked = true;
            }
            this.Hide();
            MainScreen f1 = new MainScreen();
            f1.Show();            
        }
        //Cancel Button
        private void buttonModifyPartCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainScreen().ShowDialog();
        }

        private void BoxModifyPartInv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BoxModifyPartMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BoxModifyPartMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BoxModifyPartPriceCost_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BoxModifyPartName_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BoxModifyPartName.Text))
            {
                BoxModifyPartName.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                BoxModifyPartName.BackColor = System.Drawing.Color.White;
            }
            buttonModifyPartSave.Enabled = allowSave();
        }

        private void BoxModifyPartInv_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BoxModifyPartInv.Text))
            {
                BoxModifyPartInv.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                BoxModifyPartInv.BackColor = System.Drawing.Color.White;
            }
            buttonModifyPartSave.Enabled = allowSave();
        }

        private void BoxModifyPartPriceCost_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BoxModifyPartPriceCost.Text))
            {
                BoxModifyPartPriceCost.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                BoxModifyPartPriceCost.BackColor = System.Drawing.Color.White;
            }
            buttonModifyPartSave.Enabled = allowSave();
        }

        private void BoxModifyPartMax_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BoxModifyPartMax.Text))
            {
                BoxModifyPartMax.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                BoxModifyPartMax.BackColor = System.Drawing.Color.White;
            }
            buttonModifyPartSave.Enabled = allowSave();
        }

        private void BoxModifyPartMin_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BoxModifyPartMin.Text))
            {
                BoxModifyPartMin.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                BoxModifyPartMin.BackColor = System.Drawing.Color.White;
            }
            buttonModifyPartSave.Enabled = allowSave();
        }

        private void BoxModifyPartMachineID_TextChanged(object sender, EventArgs e)
        {
            checkOnRBSwitch();
        }

        private void BoxModifyPartMachineID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioModifyPartInHouse.Checked && (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')))
            {
                e.Handled = true;
            }
        }
    }
}
