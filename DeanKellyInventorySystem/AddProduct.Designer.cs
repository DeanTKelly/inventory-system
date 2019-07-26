namespace DeanKellyInventorySystem
{
    partial class AddProduct
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
            this.labelAddProduct = new System.Windows.Forms.Label();
            this.labelAddProductID = new System.Windows.Forms.Label();
            this.labelAddProductName = new System.Windows.Forms.Label();
            this.labelAddProductInv = new System.Windows.Forms.Label();
            this.labelAddProductPrice = new System.Windows.Forms.Label();
            this.labelAddProductMax = new System.Windows.Forms.Label();
            this.labelAddProductMin = new System.Windows.Forms.Label();
            this.textBoxAddProductMax = new System.Windows.Forms.TextBox();
            this.textBoxAddProductPrice = new System.Windows.Forms.TextBox();
            this.textBoxAddProductInv = new System.Windows.Forms.TextBox();
            this.textBoxAddProductName = new System.Windows.Forms.TextBox();
            this.textBoxAddProductID = new System.Windows.Forms.TextBox();
            this.textBoxAddProductMin = new System.Windows.Forms.TextBox();
            this.buttonAddProductSearch = new System.Windows.Forms.Button();
            this.textBoxAddProductSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewAddProduct1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewAddProduct2 = new System.Windows.Forms.DataGridView();
            this.buttonAddProductAdd = new System.Windows.Forms.Button();
            this.buttonAddProductDelete = new System.Windows.Forms.Button();
            this.buttonAddProductCancel = new System.Windows.Forms.Button();
            this.buttonAddProductSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddProduct1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddProduct2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddProduct
            // 
            this.labelAddProduct.AutoSize = true;
            this.labelAddProduct.Location = new System.Drawing.Point(12, 9);
            this.labelAddProduct.Name = "labelAddProduct";
            this.labelAddProduct.Size = new System.Drawing.Size(86, 17);
            this.labelAddProduct.TabIndex = 0;
            this.labelAddProduct.Text = "Add Product";
            // 
            // labelAddProductID
            // 
            this.labelAddProductID.AutoSize = true;
            this.labelAddProductID.Location = new System.Drawing.Point(21, 139);
            this.labelAddProductID.Name = "labelAddProductID";
            this.labelAddProductID.Size = new System.Drawing.Size(21, 17);
            this.labelAddProductID.TabIndex = 1;
            this.labelAddProductID.Text = "ID";
            // 
            // labelAddProductName
            // 
            this.labelAddProductName.AutoSize = true;
            this.labelAddProductName.Location = new System.Drawing.Point(21, 188);
            this.labelAddProductName.Name = "labelAddProductName";
            this.labelAddProductName.Size = new System.Drawing.Size(45, 17);
            this.labelAddProductName.TabIndex = 2;
            this.labelAddProductName.Text = "Name";
            // 
            // labelAddProductInv
            // 
            this.labelAddProductInv.AutoSize = true;
            this.labelAddProductInv.Location = new System.Drawing.Point(21, 239);
            this.labelAddProductInv.Name = "labelAddProductInv";
            this.labelAddProductInv.Size = new System.Drawing.Size(26, 17);
            this.labelAddProductInv.TabIndex = 3;
            this.labelAddProductInv.Text = "Inv";
            // 
            // labelAddProductPrice
            // 
            this.labelAddProductPrice.AutoSize = true;
            this.labelAddProductPrice.Location = new System.Drawing.Point(21, 286);
            this.labelAddProductPrice.Name = "labelAddProductPrice";
            this.labelAddProductPrice.Size = new System.Drawing.Size(40, 17);
            this.labelAddProductPrice.TabIndex = 4;
            this.labelAddProductPrice.Text = "Price";
            // 
            // labelAddProductMax
            // 
            this.labelAddProductMax.AutoSize = true;
            this.labelAddProductMax.Location = new System.Drawing.Point(21, 336);
            this.labelAddProductMax.Name = "labelAddProductMax";
            this.labelAddProductMax.Size = new System.Drawing.Size(33, 17);
            this.labelAddProductMax.TabIndex = 5;
            this.labelAddProductMax.Text = "Max";
            // 
            // labelAddProductMin
            // 
            this.labelAddProductMin.AutoSize = true;
            this.labelAddProductMin.Location = new System.Drawing.Point(179, 336);
            this.labelAddProductMin.Name = "labelAddProductMin";
            this.labelAddProductMin.Size = new System.Drawing.Size(30, 17);
            this.labelAddProductMin.TabIndex = 6;
            this.labelAddProductMin.Text = "Min";
            // 
            // textBoxAddProductMax
            // 
            this.textBoxAddProductMax.Location = new System.Drawing.Point(85, 331);
            this.textBoxAddProductMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddProductMax.Name = "textBoxAddProductMax";
            this.textBoxAddProductMax.Size = new System.Drawing.Size(69, 22);
            this.textBoxAddProductMax.TabIndex = 7;
            this.textBoxAddProductMax.TextChanged += new System.EventHandler(this.textBoxAddProductMax_TextChanged);
            this.textBoxAddProductMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddProductMax_KeyPress);
            // 
            // textBoxAddProductPrice
            // 
            this.textBoxAddProductPrice.Location = new System.Drawing.Point(85, 282);
            this.textBoxAddProductPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddProductPrice.Name = "textBoxAddProductPrice";
            this.textBoxAddProductPrice.Size = new System.Drawing.Size(132, 22);
            this.textBoxAddProductPrice.TabIndex = 8;
            this.textBoxAddProductPrice.TextChanged += new System.EventHandler(this.textBoxAddProductPrice_TextChanged);
            this.textBoxAddProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddProductPrice_KeyPress);
            // 
            // textBoxAddProductInv
            // 
            this.textBoxAddProductInv.Location = new System.Drawing.Point(85, 236);
            this.textBoxAddProductInv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddProductInv.Name = "textBoxAddProductInv";
            this.textBoxAddProductInv.Size = new System.Drawing.Size(132, 22);
            this.textBoxAddProductInv.TabIndex = 9;
            this.textBoxAddProductInv.TextChanged += new System.EventHandler(this.textBoxAddProductInv_TextChanged);
            this.textBoxAddProductInv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddProductInv_KeyPress);
            // 
            // textBoxAddProductName
            // 
            this.textBoxAddProductName.Location = new System.Drawing.Point(85, 183);
            this.textBoxAddProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddProductName.Name = "textBoxAddProductName";
            this.textBoxAddProductName.Size = new System.Drawing.Size(132, 22);
            this.textBoxAddProductName.TabIndex = 10;
            this.textBoxAddProductName.TextChanged += new System.EventHandler(this.textBoxAddProductName_TextChanged);
            // 
            // textBoxAddProductID
            // 
            this.textBoxAddProductID.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAddProductID.Location = new System.Drawing.Point(85, 134);
            this.textBoxAddProductID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddProductID.Name = "textBoxAddProductID";
            this.textBoxAddProductID.ReadOnly = true;
            this.textBoxAddProductID.Size = new System.Drawing.Size(132, 22);
            this.textBoxAddProductID.TabIndex = 11;
            this.textBoxAddProductID.Text = "Auto Gen - Disabled";
            // 
            // textBoxAddProductMin
            // 
            this.textBoxAddProductMin.Location = new System.Drawing.Point(229, 331);
            this.textBoxAddProductMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddProductMin.Name = "textBoxAddProductMin";
            this.textBoxAddProductMin.Size = new System.Drawing.Size(69, 22);
            this.textBoxAddProductMin.TabIndex = 12;
            this.textBoxAddProductMin.TextChanged += new System.EventHandler(this.textBoxAddProductMin_TextChanged);
            this.textBoxAddProductMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddProductMin_KeyPress);
            // 
            // buttonAddProductSearch
            // 
            this.buttonAddProductSearch.Location = new System.Drawing.Point(589, 42);
            this.buttonAddProductSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddProductSearch.Name = "buttonAddProductSearch";
            this.buttonAddProductSearch.Size = new System.Drawing.Size(101, 30);
            this.buttonAddProductSearch.TabIndex = 13;
            this.buttonAddProductSearch.Text = "Search";
            this.buttonAddProductSearch.UseVisualStyleBackColor = true;
            this.buttonAddProductSearch.Click += new System.EventHandler(this.buttonAddProductSearch_Click);
            // 
            // textBoxAddProductSearch
            // 
            this.textBoxAddProductSearch.Location = new System.Drawing.Point(712, 46);
            this.textBoxAddProductSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddProductSearch.Name = "textBoxAddProductSearch";
            this.textBoxAddProductSearch.Size = new System.Drawing.Size(207, 22);
            this.textBoxAddProductSearch.TabIndex = 14;
            // 
            // dataGridViewAddProduct1
            // 
            this.dataGridViewAddProduct1.AllowUserToAddRows = false;
            this.dataGridViewAddProduct1.AllowUserToDeleteRows = false;
            this.dataGridViewAddProduct1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddProduct1.Location = new System.Drawing.Point(413, 94);
            this.dataGridViewAddProduct1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAddProduct1.Name = "dataGridViewAddProduct1";
            this.dataGridViewAddProduct1.ReadOnly = true;
            this.dataGridViewAddProduct1.RowTemplate.Height = 24;
            this.dataGridViewAddProduct1.Size = new System.Drawing.Size(536, 150);
            this.dataGridViewAddProduct1.TabIndex = 15;
            // 
            // dataGridViewAddProduct2
            // 
            this.dataGridViewAddProduct2.AllowUserToAddRows = false;
            this.dataGridViewAddProduct2.AllowUserToDeleteRows = false;
            this.dataGridViewAddProduct2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddProduct2.Location = new System.Drawing.Point(413, 294);
            this.dataGridViewAddProduct2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAddProduct2.Name = "dataGridViewAddProduct2";
            this.dataGridViewAddProduct2.ReadOnly = true;
            this.dataGridViewAddProduct2.RowTemplate.Height = 24;
            this.dataGridViewAddProduct2.Size = new System.Drawing.Size(536, 150);
            this.dataGridViewAddProduct2.TabIndex = 16;
            // 
            // buttonAddProductAdd
            // 
            this.buttonAddProductAdd.Location = new System.Drawing.Point(847, 255);
            this.buttonAddProductAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddProductAdd.Name = "buttonAddProductAdd";
            this.buttonAddProductAdd.Size = new System.Drawing.Size(101, 30);
            this.buttonAddProductAdd.TabIndex = 17;
            this.buttonAddProductAdd.Text = "Add";
            this.buttonAddProductAdd.UseVisualStyleBackColor = true;
            this.buttonAddProductAdd.Click += new System.EventHandler(this.buttonAddProductAdd_Click);
            // 
            // buttonAddProductDelete
            // 
            this.buttonAddProductDelete.Location = new System.Drawing.Point(847, 453);
            this.buttonAddProductDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddProductDelete.Name = "buttonAddProductDelete";
            this.buttonAddProductDelete.Size = new System.Drawing.Size(101, 30);
            this.buttonAddProductDelete.TabIndex = 18;
            this.buttonAddProductDelete.Text = "Delete";
            this.buttonAddProductDelete.UseVisualStyleBackColor = true;
            this.buttonAddProductDelete.Click += new System.EventHandler(this.buttonAddProductDelete_Click);
            // 
            // buttonAddProductCancel
            // 
            this.buttonAddProductCancel.Location = new System.Drawing.Point(847, 500);
            this.buttonAddProductCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddProductCancel.Name = "buttonAddProductCancel";
            this.buttonAddProductCancel.Size = new System.Drawing.Size(101, 30);
            this.buttonAddProductCancel.TabIndex = 19;
            this.buttonAddProductCancel.Text = "Cancel";
            this.buttonAddProductCancel.UseVisualStyleBackColor = true;
            this.buttonAddProductCancel.Click += new System.EventHandler(this.buttonAddProductCancel_Click);
            // 
            // buttonAddProductSave
            // 
            this.buttonAddProductSave.Location = new System.Drawing.Point(712, 500);
            this.buttonAddProductSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddProductSave.Name = "buttonAddProductSave";
            this.buttonAddProductSave.Size = new System.Drawing.Size(101, 30);
            this.buttonAddProductSave.TabIndex = 20;
            this.buttonAddProductSave.Text = "Save";
            this.buttonAddProductSave.UseVisualStyleBackColor = true;
            this.buttonAddProductSave.Click += new System.EventHandler(this.buttonAddProductSave_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 553);
            this.Controls.Add(this.buttonAddProductSave);
            this.Controls.Add(this.buttonAddProductCancel);
            this.Controls.Add(this.buttonAddProductDelete);
            this.Controls.Add(this.buttonAddProductAdd);
            this.Controls.Add(this.dataGridViewAddProduct2);
            this.Controls.Add(this.dataGridViewAddProduct1);
            this.Controls.Add(this.textBoxAddProductSearch);
            this.Controls.Add(this.buttonAddProductSearch);
            this.Controls.Add(this.textBoxAddProductMin);
            this.Controls.Add(this.textBoxAddProductID);
            this.Controls.Add(this.textBoxAddProductName);
            this.Controls.Add(this.textBoxAddProductInv);
            this.Controls.Add(this.textBoxAddProductPrice);
            this.Controls.Add(this.textBoxAddProductMax);
            this.Controls.Add(this.labelAddProductMin);
            this.Controls.Add(this.labelAddProductMax);
            this.Controls.Add(this.labelAddProductPrice);
            this.Controls.Add(this.labelAddProductInv);
            this.Controls.Add(this.labelAddProductName);
            this.Controls.Add(this.labelAddProductID);
            this.Controls.Add(this.labelAddProduct);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddProduct1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddProduct2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddProduct;
        private System.Windows.Forms.Label labelAddProductID;
        private System.Windows.Forms.Label labelAddProductName;
        private System.Windows.Forms.Label labelAddProductInv;
        private System.Windows.Forms.Label labelAddProductPrice;
        private System.Windows.Forms.Label labelAddProductMax;
        private System.Windows.Forms.Label labelAddProductMin;
        private System.Windows.Forms.TextBox textBoxAddProductMax;
        private System.Windows.Forms.TextBox textBoxAddProductPrice;
        private System.Windows.Forms.TextBox textBoxAddProductInv;
        private System.Windows.Forms.TextBox textBoxAddProductName;
        private System.Windows.Forms.TextBox textBoxAddProductID;
        private System.Windows.Forms.TextBox textBoxAddProductMin;
        private System.Windows.Forms.Button buttonAddProductSearch;
        private System.Windows.Forms.TextBox textBoxAddProductSearch;
        private System.Windows.Forms.DataGridView dataGridViewAddProduct1;
        private System.Windows.Forms.DataGridView dataGridViewAddProduct2;
        private System.Windows.Forms.Button buttonAddProductAdd;
        private System.Windows.Forms.Button buttonAddProductDelete;
        private System.Windows.Forms.Button buttonAddProductCancel;
        private System.Windows.Forms.Button buttonAddProductSave;

        public int BoxAddProductSearch
        {
            get
            {
                return int.Parse(textBoxAddProductSearch.Text);
            }
            set { textBoxAddProductSearch.Text = value.ToString(); }
        }
        public int BoxAddProductID
        {
            get { return int.Parse(textBoxAddProductID.Text); }
            set { textBoxAddProductID.Text = value.ToString(); }
        }

        public string BoxAddProductName
        {
            get { return textBoxAddProductName.Text; }
            set { textBoxAddProductName.Text = value; }
        }

        public int BoxAddProductInv
        {
            get { return int.Parse(textBoxAddProductInv.Text); }
            set { textBoxAddProductInv.Text = value.ToString(); }
        }

        public double BoxAddProductPrice
        {
            get { return double.Parse(textBoxAddProductPrice.Text); }
            set { textBoxAddProductPrice.Text = value.ToString(); }
        }

        public int BoxAddProductMax
        {
            get { return int.Parse(textBoxAddProductMax.Text); }
            set { textBoxAddProductMax.Text = value.ToString(); }
        }
        public int BoxAddProductMin
        {
            get { return int.Parse(textBoxAddProductMin.Text); }
            set { textBoxAddProductMin.Text = value.ToString(); }
        }        
    }
}