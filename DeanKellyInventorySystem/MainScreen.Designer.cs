namespace DeanKellyInventorySystem
{
    partial class MainScreen
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
            this.labelMainScreen = new System.Windows.Forms.Label();
            this.groupBoxParts = new System.Windows.Forms.GroupBox();
            this.buttonAddPart = new System.Windows.Forms.Button();
            this.buttonModifyPart = new System.Windows.Forms.Button();
            this.buttonDeletePart = new System.Windows.Forms.Button();
            this.buttonPartsSearch = new System.Windows.Forms.Button();
            this.labelParts = new System.Windows.Forms.Label();
            this.dataGridViewParts = new System.Windows.Forms.DataGridView();
            this.boxPartSearch = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonModifyProduct = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonProductsSearch = new System.Windows.Forms.Button();
            this.groupBoxProducts = new System.Windows.Forms.GroupBox();
            this.labelProducts = new System.Windows.Forms.Label();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.boxProductSearch = new System.Windows.Forms.TextBox();
            this.groupBoxParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).BeginInit();
            this.groupBoxProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMainScreen
            // 
            this.labelMainScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMainScreen.Location = new System.Drawing.Point(13, 14);
            this.labelMainScreen.Name = "labelMainScreen";
            this.labelMainScreen.Size = new System.Drawing.Size(289, 34);
            this.labelMainScreen.TabIndex = 0;
            this.labelMainScreen.Text = "Inventory Management System";
            // 
            // groupBoxParts
            // 
            this.groupBoxParts.Controls.Add(this.buttonAddPart);
            this.groupBoxParts.Controls.Add(this.buttonModifyPart);
            this.groupBoxParts.Controls.Add(this.buttonDeletePart);
            this.groupBoxParts.Controls.Add(this.buttonPartsSearch);
            this.groupBoxParts.Controls.Add(this.labelParts);
            this.groupBoxParts.Controls.Add(this.dataGridViewParts);
            this.groupBoxParts.Controls.Add(this.boxPartSearch);
            this.groupBoxParts.Location = new System.Drawing.Point(28, 68);
            this.groupBoxParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxParts.Name = "groupBoxParts";
            this.groupBoxParts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxParts.Size = new System.Drawing.Size(571, 309);
            this.groupBoxParts.TabIndex = 1;
            this.groupBoxParts.TabStop = false;
            // 
            // buttonAddPart
            // 
            this.buttonAddPart.Location = new System.Drawing.Point(301, 270);
            this.buttonAddPart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddPart.Name = "buttonAddPart";
            this.buttonAddPart.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPart.TabIndex = 8;
            this.buttonAddPart.Text = "Add";
            this.buttonAddPart.UseVisualStyleBackColor = true;
            this.buttonAddPart.Click += new System.EventHandler(this.buttonAddPart_Click);
            // 
            // buttonModifyPart
            // 
            this.buttonModifyPart.Location = new System.Drawing.Point(381, 270);
            this.buttonModifyPart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModifyPart.Name = "buttonModifyPart";
            this.buttonModifyPart.Size = new System.Drawing.Size(75, 23);
            this.buttonModifyPart.TabIndex = 7;
            this.buttonModifyPart.Text = "Modify";
            this.buttonModifyPart.UseVisualStyleBackColor = true;
            this.buttonModifyPart.Click += new System.EventHandler(this.buttonModifyPart_Click);
            // 
            // buttonDeletePart
            // 
            this.buttonDeletePart.Location = new System.Drawing.Point(461, 270);
            this.buttonDeletePart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeletePart.Name = "buttonDeletePart";
            this.buttonDeletePart.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletePart.TabIndex = 6;
            this.buttonDeletePart.Text = "Delete";
            this.buttonDeletePart.UseVisualStyleBackColor = true;
            this.buttonDeletePart.Click += new System.EventHandler(this.buttonDeletePart_Click);
            // 
            // buttonPartsSearch
            // 
            this.buttonPartsSearch.Location = new System.Drawing.Point(219, 21);
            this.buttonPartsSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPartsSearch.Name = "buttonPartsSearch";
            this.buttonPartsSearch.Size = new System.Drawing.Size(65, 23);
            this.buttonPartsSearch.TabIndex = 9;
            this.buttonPartsSearch.Text = "Search";
            this.buttonPartsSearch.UseVisualStyleBackColor = true;
            this.buttonPartsSearch.Click += new System.EventHandler(this.buttonPartsSearch_Click);
            // 
            // labelParts
            // 
            this.labelParts.AutoSize = true;
            this.labelParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelParts.Location = new System.Drawing.Point(7, 17);
            this.labelParts.Name = "labelParts";
            this.labelParts.Size = new System.Drawing.Size(57, 25);
            this.labelParts.TabIndex = 2;
            this.labelParts.Text = "Parts";
            // 
            // dataGridViewParts
            // 
            this.dataGridViewParts.AllowUserToAddRows = false;
            this.dataGridViewParts.AllowUserToDeleteRows = false;
            this.dataGridViewParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParts.Location = new System.Drawing.Point(20, 59);
            this.dataGridViewParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewParts.Name = "dataGridViewParts";
            this.dataGridViewParts.ReadOnly = true;
            this.dataGridViewParts.RowTemplate.Height = 24;
            this.dataGridViewParts.Size = new System.Drawing.Size(531, 202);
            this.dataGridViewParts.TabIndex = 1;
            this.dataGridViewParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewParts_CellClick);
            this.dataGridViewParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewParts_CellContentClick);
            // 
            // boxPartSearch
            // 
            this.boxPartSearch.Location = new System.Drawing.Point(301, 23);
            this.boxPartSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxPartSearch.Name = "boxPartSearch";
            this.boxPartSearch.Size = new System.Drawing.Size(249, 22);
            this.boxPartSearch.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1133, 391);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(87, 50);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(309, 268);
            this.buttonAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonAddProduct.TabIndex = 3;
            this.buttonAddProduct.Text = "Add";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonModifyProduct
            // 
            this.buttonModifyProduct.Location = new System.Drawing.Point(389, 268);
            this.buttonModifyProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModifyProduct.Name = "buttonModifyProduct";
            this.buttonModifyProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonModifyProduct.TabIndex = 4;
            this.buttonModifyProduct.Text = "Modify";
            this.buttonModifyProduct.UseVisualStyleBackColor = true;
            this.buttonModifyProduct.Click += new System.EventHandler(this.buttonModifyProduct_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(469, 268);
            this.buttonDeleteProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteProduct.TabIndex = 5;
            this.buttonDeleteProduct.Text = "Delete";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonProductsSearch
            // 
            this.buttonProductsSearch.Location = new System.Drawing.Point(227, 21);
            this.buttonProductsSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonProductsSearch.Name = "buttonProductsSearch";
            this.buttonProductsSearch.Size = new System.Drawing.Size(65, 23);
            this.buttonProductsSearch.TabIndex = 10;
            this.buttonProductsSearch.Text = "Search";
            this.buttonProductsSearch.UseVisualStyleBackColor = true;
            this.buttonProductsSearch.Click += new System.EventHandler(this.buttonProductsSearch_Click);
            // 
            // groupBoxProducts
            // 
            this.groupBoxProducts.Controls.Add(this.buttonAddProduct);
            this.groupBoxProducts.Controls.Add(this.buttonModifyProduct);
            this.groupBoxProducts.Controls.Add(this.buttonDeleteProduct);
            this.groupBoxProducts.Controls.Add(this.labelProducts);
            this.groupBoxProducts.Controls.Add(this.dataGridViewProducts);
            this.groupBoxProducts.Controls.Add(this.boxProductSearch);
            this.groupBoxProducts.Controls.Add(this.buttonProductsSearch);
            this.groupBoxProducts.Location = new System.Drawing.Point(651, 69);
            this.groupBoxProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxProducts.Name = "groupBoxProducts";
            this.groupBoxProducts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxProducts.Size = new System.Drawing.Size(571, 308);
            this.groupBoxProducts.TabIndex = 11;
            this.groupBoxProducts.TabStop = false;
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelProducts.Location = new System.Drawing.Point(5, 16);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(89, 25);
            this.labelProducts.TabIndex = 13;
            this.labelProducts.Text = "Products";
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(19, 58);
            this.dataGridViewProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.Size = new System.Drawing.Size(532, 202);
            this.dataGridViewProducts.TabIndex = 12;
            // 
            // boxProductSearch
            // 
            this.boxProductSearch.Location = new System.Drawing.Point(309, 21);
            this.boxProductSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxProductSearch.Name = "boxProductSearch";
            this.boxProductSearch.Size = new System.Drawing.Size(237, 22);
            this.boxProductSearch.TabIndex = 11;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 453);
            this.Controls.Add(this.groupBoxProducts);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxParts);
            this.Controls.Add(this.labelMainScreen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.groupBoxParts.ResumeLayout(false);
            this.groupBoxParts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).EndInit();
            this.groupBoxProducts.ResumeLayout(false);
            this.groupBoxProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMainScreen;
        private System.Windows.Forms.GroupBox groupBoxParts;
        public System.Windows.Forms.DataGridView dataGridViewParts;
        private System.Windows.Forms.TextBox boxPartSearch;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonModifyProduct;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonPartsSearch;
        private System.Windows.Forms.Button buttonProductsSearch;
        private System.Windows.Forms.GroupBox groupBoxProducts;
        private System.Windows.Forms.TextBox boxProductSearch;
        public System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Label labelParts;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Button buttonAddPart;
        private System.Windows.Forms.Button buttonModifyPart;
        private System.Windows.Forms.Button buttonDeletePart;

        public int textBoxPartSearch
        {
            get {
                return int.Parse(boxPartSearch.Text); }
            set { boxPartSearch.Text = value.ToString(); }
        }

        public int textBoxProductSearch
        {
            get { return int.Parse(boxProductSearch.Text); }
            set { boxProductSearch.Text = value.ToString(); }
        }
    }
}

