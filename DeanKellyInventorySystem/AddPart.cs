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
    partial class AddPart : Form
    {
        bool isInHouse;
        
        private bool allowSave()
        {
            int number;
            return (!string.IsNullOrWhiteSpace(BoxAddPartName.Text) && !string.IsNullOrWhiteSpace(BoxAddPartInv.Text) &&
                !string.IsNullOrWhiteSpace(BoxAddPartPriceCost.Text) && !string.IsNullOrWhiteSpace(BoxAddPartMin.Text) && !string.IsNullOrWhiteSpace(BoxAddPartMax.Text)) &&
                (!(string.IsNullOrWhiteSpace(BoxAddPartMachineID.Text) || (isInHouse && !Int32.TryParse(BoxAddPartMachineID.Text, out number))));
        }

        private void checkOnRBSwitch()
        {
            int number;
            if (string.IsNullOrWhiteSpace(BoxAddPartMachineID.Text) || (isInHouse && !Int32.TryParse(BoxAddPartMachineID.Text, out number)))
            {
                BoxAddPartMachineID.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                BoxAddPartMachineID.BackColor = System.Drawing.Color.White;
            }
            buttonAddPartSave.Enabled = allowSave();
        }

        public AddPart(Inhouse inPart)
        {
            InitializeComponent();

            textBoxAddPartID = inPart.PartID;
            textBoxAddPartName = inPart.Name;
            textBoxAddPartInv = inPart.InStock;
            textBoxAddPartPriceCost = inPart.Price;
            textBoxAddPartMin = inPart.Min;
            textBoxAddPartMax = inPart.Max;
            textBoxAddPartMachineID = inPart.MachineID.ToString();
            if (Inventory.CurrentPart is Inhouse)
            {
                Inhouse e = (Inhouse)Inventory.CurrentPart;
                BoxAddPartMachineID.Text = e.MachineID.ToString();
                isInHouse = true;
                radioAddPartInHouse.Checked = true;
            }
            else
            {
                Outsourced e = (Outsourced)Inventory.CurrentPart;
                BoxAddPartMachineID.Text = e.CompanyName;
                isInHouse = false;
                radioAddPartOutsourced.Checked = true;
            }
        }

        public AddPart(Outsourced outPart)
        {
            InitializeComponent();

            textBoxAddPartID = outPart.PartID;
            textBoxAddPartName = outPart.Name;
            textBoxAddPartInv = outPart.InStock;
            textBoxAddPartPriceCost = outPart.Price;
            textBoxAddPartMin = outPart.Min;
            textBoxAddPartMax = outPart.Max;
            textBoxAddPartMachineID = outPart.CompanyName;

            radioAddPartOutsourced.Checked = true;
        }

        public AddPart()
        {
            InitializeComponent();            
        }

        //Radio Buttons
        //
        //Inhouse Radio Button
        private void radioAddPartInHouse_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Machine ID";
            BoxAddPartMachineID.Text = "Machine ID";
            checkOnRBSwitch();
        }
        //Outsourced Radio Button
        private void radioAddPartOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Company Name";
            BoxAddPartMachineID.Text = "Company Name";
            checkOnRBSwitch();
        }
        //
        //Save Button
        private void buttonAddPartSave_Click(object sender, EventArgs e)
        {
            try
            {

                //Exception Min must not exceed Max
                if (textBoxAddPartMax < textBoxAddPartMin)
                {
                    MessageBox.Show("Minimum must not exceed maximum");
                    return;
                }
            }
            catch (FormatException formatException)
            {
                MessageBox.Show("Please enter a numeric value for Min and Max.");
            }
            try
            {
                //Exception Inventory must be between min and max
                if (textBoxAddPartInv < textBoxAddPartMin || textBoxAddPartInv > textBoxAddPartMax)
                {
                    MessageBox.Show("Inventory must be between minimum and maximum");
                    return;
                }
            }
            catch (FormatException formatException)
            {
                MessageBox.Show("Please enter a numeric value for Inv.");
            }
            try
            {
                if (radioAddPartInHouse.Checked)
                {
                    Inhouse inHouse = new Inhouse((Inventory.AllParts.Count + 1), textBoxAddPartName, textBoxAddPartPriceCost, textBoxAddPartInv,
                                                    textBoxAddPartMin, textBoxAddPartMax, int.Parse(textBoxAddPartMachineID));
                    Inventory.AddPart(inHouse);
                }
                else
                {
                    //Exception Min must not exceed Max
                    if (textBoxAddPartMax < textBoxAddPartMin)
                    {
                        MessageBox.Show("Minimum must not exceed maximum");
                        return;
                    }
                    //Exception Inventory must be between min and max
                    if (textBoxAddPartInv < textBoxAddPartMin || textBoxAddPartInv > textBoxAddPartMax)
                    {
                        MessageBox.Show("Inventory must be between minimum and maximum");
                        return;
                    }
                    Outsourced outsourced = new Outsourced((Inventory.AllParts.Count + 1), textBoxAddPartName, textBoxAddPartPriceCost, textBoxAddPartInv,
                                                    textBoxAddPartMin, textBoxAddPartMax, textBoxAddPartMachineID);
                    Inventory.AddPart(outsourced);
                }
            }
            catch (FormatException formatException)
            {
                MessageBox.Show("Price must be a numeric value");
            }
            this.Hide();
            MainScreen f1 = new MainScreen();
            f1.Show();
        }
        //Cancel Button
        private void buttonAddPartCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainScreen().ShowDialog();
        }

        private void BoxAddPartInv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BoxAddPartMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BoxAddPartMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BoxAddPartPriceCost_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BoxAddPartMachineID_TextChanged(object sender, EventArgs e)
        {
            int number;
            if ((isInHouse && !Int32.TryParse(BoxAddPartMachineID.Text, out number)) || string.IsNullOrWhiteSpace(BoxAddPartMachineID.Text))
            {
                BoxAddPartMachineID.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                BoxAddPartMachineID.BackColor = System.Drawing.Color.White;
            }
            buttonAddPartSave.Enabled = allowSave();
        }

        private void BoxAddPartName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BoxAddPartName.Text))
            {
                BoxAddPartName.BackColor = System.Drawing.Color.Salmon;
            }            
            else
            {
                BoxAddPartName.BackColor = System.Drawing.Color.White;
            }
            buttonAddPartSave.Enabled = allowSave();
        }

        private void BoxAddPartInv_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BoxAddPartInv.Text))
            {
                BoxAddPartInv.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                BoxAddPartInv.BackColor = System.Drawing.Color.White;
            }
            buttonAddPartSave.Enabled = allowSave();

        }

        private void BoxAddPartPriceCost_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BoxAddPartPriceCost.Text))
            {
                BoxAddPartPriceCost.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                BoxAddPartPriceCost.BackColor = System.Drawing.Color.White;
            }
            buttonAddPartSave.Enabled = allowSave();
        }

        private void BoxAddPartMax_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BoxAddPartMax.Text))
            {
                BoxAddPartMax.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                BoxAddPartMax.BackColor = System.Drawing.Color.White;
            }
            buttonAddPartSave.Enabled = allowSave();
        }

        private void BoxAddPartMin_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BoxAddPartMin.Text))
            {
                BoxAddPartMin.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                BoxAddPartMin.BackColor = System.Drawing.Color.White;
            }
            buttonAddPartSave.Enabled = allowSave();
        }

        private void BoxAddPartMachineID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioAddPartInHouse.Checked && (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')))
                    {
                e.Handled = true;
            }            
        }
    }
}
