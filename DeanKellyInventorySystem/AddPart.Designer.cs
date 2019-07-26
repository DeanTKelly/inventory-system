namespace DeanKellyInventorySystem
{
    partial class AddPart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAddPart = new System.Windows.Forms.Label();
            this.radioAddPartInHouse = new System.Windows.Forms.RadioButton();
            this.radioAddPartOutsourced = new System.Windows.Forms.RadioButton();
            this.labelAddPartID = new System.Windows.Forms.Label();
            this.labelAddPartName = new System.Windows.Forms.Label();
            this.labelAddPartInv = new System.Windows.Forms.Label();
            this.labelAddPartPriceCost = new System.Windows.Forms.Label();
            this.labelAddPartMax = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BoxAddPartID = new System.Windows.Forms.TextBox();
            this.BoxAddPartName = new System.Windows.Forms.TextBox();
            this.BoxAddPartInv = new System.Windows.Forms.TextBox();
            this.BoxAddPartPriceCost = new System.Windows.Forms.TextBox();
            this.BoxAddPartMax = new System.Windows.Forms.TextBox();
            this.BoxAddPartMachineID = new System.Windows.Forms.TextBox();
            this.labelAddPartMin = new System.Windows.Forms.Label();
            this.BoxAddPartMin = new System.Windows.Forms.TextBox();
            this.buttonAddPartSave = new System.Windows.Forms.Button();
            this.buttonAddPartCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddPart
            // 
            this.labelAddPart.AutoSize = true;
            this.labelAddPart.Location = new System.Drawing.Point(13, 14);
            this.labelAddPart.Name = "labelAddPart";
            this.labelAddPart.Size = new System.Drawing.Size(63, 17);
            this.labelAddPart.TabIndex = 0;
            this.labelAddPart.Text = "Add Part";
            // 
            // radioAddPartInHouse
            // 
            this.radioAddPartInHouse.AutoSize = true;
            this.radioAddPartInHouse.Checked = true;
            this.radioAddPartInHouse.Location = new System.Drawing.Point(149, 32);
            this.radioAddPartInHouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioAddPartInHouse.Name = "radioAddPartInHouse";
            this.radioAddPartInHouse.Size = new System.Drawing.Size(86, 21);
            this.radioAddPartInHouse.TabIndex = 1;
            this.radioAddPartInHouse.TabStop = true;
            this.radioAddPartInHouse.Text = "In-House";
            this.radioAddPartInHouse.UseVisualStyleBackColor = true;
            this.radioAddPartInHouse.CheckedChanged += new System.EventHandler(this.radioAddPartInHouse_CheckedChanged);
            // 
            // radioAddPartOutsourced
            // 
            this.radioAddPartOutsourced.AutoSize = true;
            this.radioAddPartOutsourced.Location = new System.Drawing.Point(280, 32);
            this.radioAddPartOutsourced.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioAddPartOutsourced.Name = "radioAddPartOutsourced";
            this.radioAddPartOutsourced.Size = new System.Drawing.Size(103, 21);
            this.radioAddPartOutsourced.TabIndex = 2;
            this.radioAddPartOutsourced.Text = "Outsourced";
            this.radioAddPartOutsourced.UseVisualStyleBackColor = true;
            this.radioAddPartOutsourced.CheckedChanged += new System.EventHandler(this.radioAddPartOutsourced_CheckedChanged);
            // 
            // labelAddPartID
            // 
            this.labelAddPartID.AutoSize = true;
            this.labelAddPartID.Location = new System.Drawing.Point(55, 86);
            this.labelAddPartID.Name = "labelAddPartID";
            this.labelAddPartID.Size = new System.Drawing.Size(21, 17);
            this.labelAddPartID.TabIndex = 3;
            this.labelAddPartID.Text = "ID";
            // 
            // labelAddPartName
            // 
            this.labelAddPartName.AutoSize = true;
            this.labelAddPartName.Location = new System.Drawing.Point(55, 134);
            this.labelAddPartName.Name = "labelAddPartName";
            this.labelAddPartName.Size = new System.Drawing.Size(45, 17);
            this.labelAddPartName.TabIndex = 4;
            this.labelAddPartName.Text = "Name";
            // 
            // labelAddPartInv
            // 
            this.labelAddPartInv.AutoSize = true;
            this.labelAddPartInv.Location = new System.Drawing.Point(55, 181);
            this.labelAddPartInv.Name = "labelAddPartInv";
            this.labelAddPartInv.Size = new System.Drawing.Size(26, 17);
            this.labelAddPartInv.TabIndex = 5;
            this.labelAddPartInv.Text = "Inv";
            // 
            // labelAddPartPriceCost
            // 
            this.labelAddPartPriceCost.AutoSize = true;
            this.labelAddPartPriceCost.Location = new System.Drawing.Point(55, 234);
            this.labelAddPartPriceCost.Name = "labelAddPartPriceCost";
            this.labelAddPartPriceCost.Size = new System.Drawing.Size(72, 17);
            this.labelAddPartPriceCost.TabIndex = 6;
            this.labelAddPartPriceCost.Text = "Price/Cost";
            // 
            // labelAddPartMax
            // 
            this.labelAddPartMax.AutoSize = true;
            this.labelAddPartMax.Location = new System.Drawing.Point(55, 283);
            this.labelAddPartMax.Name = "labelAddPartMax";
            this.labelAddPartMax.Size = new System.Drawing.Size(33, 17);
            this.labelAddPartMax.TabIndex = 7;
            this.labelAddPartMax.Text = "Max";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Machine ID";
            // 
            // BoxAddPartID
            // 
            this.BoxAddPartID.BackColor = System.Drawing.SystemColors.Control;
            this.BoxAddPartID.Location = new System.Drawing.Point(181, 81);
            this.BoxAddPartID.Margin = new System.Windows.Forms.Padding(4);
            this.BoxAddPartID.Name = "BoxAddPartID";
            this.BoxAddPartID.ReadOnly = true;
            this.BoxAddPartID.Size = new System.Drawing.Size(157, 22);
            this.BoxAddPartID.TabIndex = 12;
            this.BoxAddPartID.Text = "Auto Gen - Disabled";
            // 
            // BoxAddPartName
            // 
            this.BoxAddPartName.Location = new System.Drawing.Point(181, 129);
            this.BoxAddPartName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BoxAddPartName.Name = "BoxAddPartName";
            this.BoxAddPartName.Size = new System.Drawing.Size(157, 22);
            this.BoxAddPartName.TabIndex = 10;
            this.BoxAddPartName.Text = "Part Name";
            this.BoxAddPartName.TextChanged += new System.EventHandler(this.BoxAddPartName_TextChanged);
            // 
            // BoxAddPartInv
            // 
            this.BoxAddPartInv.Location = new System.Drawing.Point(181, 176);
            this.BoxAddPartInv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BoxAddPartInv.Name = "BoxAddPartInv";
            this.BoxAddPartInv.Size = new System.Drawing.Size(157, 22);
            this.BoxAddPartInv.TabIndex = 11;
            this.BoxAddPartInv.Text = "Inv";
            this.BoxAddPartInv.TextChanged += new System.EventHandler(this.BoxAddPartInv_TextChanged);
            this.BoxAddPartInv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxAddPartInv_KeyPress);
            // 
            // BoxAddPartPriceCost
            // 
            this.BoxAddPartPriceCost.Location = new System.Drawing.Point(181, 229);
            this.BoxAddPartPriceCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BoxAddPartPriceCost.Name = "BoxAddPartPriceCost";
            this.BoxAddPartPriceCost.Size = new System.Drawing.Size(157, 22);
            this.BoxAddPartPriceCost.TabIndex = 12;
            this.BoxAddPartPriceCost.Text = "Price/Cost";
            this.BoxAddPartPriceCost.TextChanged += new System.EventHandler(this.BoxAddPartPriceCost_TextChanged);
            this.BoxAddPartPriceCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxAddPartPriceCost_KeyPress);
            // 
            // BoxAddPartMax
            // 
            this.BoxAddPartMax.Location = new System.Drawing.Point(181, 283);
            this.BoxAddPartMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BoxAddPartMax.Name = "BoxAddPartMax";
            this.BoxAddPartMax.Size = new System.Drawing.Size(67, 22);
            this.BoxAddPartMax.TabIndex = 13;
            this.BoxAddPartMax.Text = "Max";
            this.BoxAddPartMax.TextChanged += new System.EventHandler(this.BoxAddPartMax_TextChanged);
            this.BoxAddPartMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxAddPartMax_KeyPress);
            // 
            // BoxAddPartMachineID
            // 
            this.BoxAddPartMachineID.Location = new System.Drawing.Point(181, 331);
            this.BoxAddPartMachineID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BoxAddPartMachineID.Name = "BoxAddPartMachineID";
            this.BoxAddPartMachineID.Size = new System.Drawing.Size(157, 22);
            this.BoxAddPartMachineID.TabIndex = 14;
            this.BoxAddPartMachineID.Text = "Mach ID";
            this.BoxAddPartMachineID.TextChanged += new System.EventHandler(this.BoxAddPartMachineID_TextChanged);
            this.BoxAddPartMachineID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxAddPartMachineID_KeyPress);
            // 
            // labelAddPartMin
            // 
            this.labelAddPartMin.AutoSize = true;
            this.labelAddPartMin.Location = new System.Drawing.Point(280, 283);
            this.labelAddPartMin.Name = "labelAddPartMin";
            this.labelAddPartMin.Size = new System.Drawing.Size(30, 17);
            this.labelAddPartMin.TabIndex = 15;
            this.labelAddPartMin.Text = "Min";
            // 
            // BoxAddPartMin
            // 
            this.BoxAddPartMin.Location = new System.Drawing.Point(355, 283);
            this.BoxAddPartMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BoxAddPartMin.Name = "BoxAddPartMin";
            this.BoxAddPartMin.Size = new System.Drawing.Size(72, 22);
            this.BoxAddPartMin.TabIndex = 16;
            this.BoxAddPartMin.Text = "Min";
            this.BoxAddPartMin.TextChanged += new System.EventHandler(this.BoxAddPartMin_TextChanged);
            this.BoxAddPartMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxAddPartMin_KeyPress);
            // 
            // buttonAddPartSave
            // 
            this.buttonAddPartSave.Location = new System.Drawing.Point(252, 402);
            this.buttonAddPartSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddPartSave.Name = "buttonAddPartSave";
            this.buttonAddPartSave.Size = new System.Drawing.Size(104, 30);
            this.buttonAddPartSave.TabIndex = 17;
            this.buttonAddPartSave.Text = "Save";
            this.buttonAddPartSave.UseVisualStyleBackColor = true;
            this.buttonAddPartSave.Click += new System.EventHandler(this.buttonAddPartSave_Click);
            // 
            // buttonAddPartCancel
            // 
            this.buttonAddPartCancel.Location = new System.Drawing.Point(379, 402);
            this.buttonAddPartCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddPartCancel.Name = "buttonAddPartCancel";
            this.buttonAddPartCancel.Size = new System.Drawing.Size(104, 30);
            this.buttonAddPartCancel.TabIndex = 18;
            this.buttonAddPartCancel.Text = "Cancel";
            this.buttonAddPartCancel.UseVisualStyleBackColor = true;
            this.buttonAddPartCancel.Click += new System.EventHandler(this.buttonAddPartCancel_Click);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 453);
            this.Controls.Add(this.buttonAddPartCancel);
            this.Controls.Add(this.buttonAddPartSave);
            this.Controls.Add(this.BoxAddPartMin);
            this.Controls.Add(this.labelAddPartMin);
            this.Controls.Add(this.BoxAddPartMachineID);
            this.Controls.Add(this.BoxAddPartMax);
            this.Controls.Add(this.BoxAddPartPriceCost);
            this.Controls.Add(this.BoxAddPartInv);
            this.Controls.Add(this.BoxAddPartName);
            this.Controls.Add(this.BoxAddPartID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelAddPartMax);
            this.Controls.Add(this.labelAddPartPriceCost);
            this.Controls.Add(this.labelAddPartInv);
            this.Controls.Add(this.labelAddPartName);
            this.Controls.Add(this.labelAddPartID);
            this.Controls.Add(this.radioAddPartOutsourced);
            this.Controls.Add(this.radioAddPartInHouse);
            this.Controls.Add(this.labelAddPart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddPart";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddPart;
        private System.Windows.Forms.RadioButton radioAddPartInHouse;
        private System.Windows.Forms.RadioButton radioAddPartOutsourced;
        private System.Windows.Forms.Label labelAddPartID;
        private System.Windows.Forms.Label labelAddPartName;
        private System.Windows.Forms.Label labelAddPartInv;
        private System.Windows.Forms.Label labelAddPartPriceCost;
        private System.Windows.Forms.Label labelAddPartMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BoxAddPartID;
        private System.Windows.Forms.TextBox BoxAddPartName;
        private System.Windows.Forms.TextBox BoxAddPartInv;
        private System.Windows.Forms.TextBox BoxAddPartPriceCost;
        private System.Windows.Forms.TextBox BoxAddPartMax;
        private System.Windows.Forms.TextBox BoxAddPartMachineID;
        private System.Windows.Forms.Label labelAddPartMin;
        private System.Windows.Forms.TextBox BoxAddPartMin;
        private System.Windows.Forms.Button buttonAddPartSave;
        private System.Windows.Forms.Button buttonAddPartCancel;

        public int textBoxAddPartID
        {
            get { return int.Parse(BoxAddPartID.Text); }
            set { BoxAddPartID.Text = value.ToString(); }
        }

        public string textBoxAddPartName
        {
            get { return BoxAddPartName.Text; }
            set { BoxAddPartName.Text = value; }
        }

        public int textBoxAddPartInv
        {
            get { return int.Parse(BoxAddPartInv.Text); }
            set { BoxAddPartInv.Text = value.ToString(); }
        }

        public double textBoxAddPartPriceCost
        {
            get { return double.Parse(BoxAddPartPriceCost.Text); }
            set { BoxAddPartPriceCost.Text = value.ToString(); }
        }

        public int textBoxAddPartMax
        {
            get { return int.Parse(BoxAddPartMax.Text); }
            set { BoxAddPartMax.Text = value.ToString(); }
        }
        public int textBoxAddPartMin
        {
            get { return int.Parse(BoxAddPartMin.Text); }
            set { BoxAddPartMin.Text = value.ToString(); }
        }

        public string textBoxAddPartMachineID
        {
            get { return BoxAddPartMachineID.Text; }
            set { BoxAddPartMachineID.Text = value; }
        }
    }
}