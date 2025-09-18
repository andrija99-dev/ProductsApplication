namespace ProductsApplication.GUI
{
    partial class MainForm
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
            AddProductPnl = new Panel();
            btnAddProduct = new Button();
            panel1 = new Panel();
            cbCategory3 = new CheckBox();
            cbCategory2 = new CheckBox();
            lblCategories = new Label();
            cbCategory1 = new CheckBox();
            tbStockQuantity = new TextBox();
            tbDescription = new TextBox();
            tbPrice = new TextBox();
            tbProductName = new TextBox();
            lblDescription = new Label();
            lblStockQuantity = new Label();
            lblPrice = new Label();
            lblProductName = new Label();
            lblAddProductPnl = new Label();
            dgProducts = new DataGridView();
            btnUpdateProduct = new Button();
            btnDeleteProduct = new Button();
            lblSearch = new Label();
            tbSearch = new TextBox();
            btnSearch = new Button();
            AddProductPnl.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            SuspendLayout();
            // 
            // AddProductPnl
            // 
            AddProductPnl.Controls.Add(btnAddProduct);
            AddProductPnl.Controls.Add(panel1);
            AddProductPnl.Controls.Add(tbStockQuantity);
            AddProductPnl.Controls.Add(tbDescription);
            AddProductPnl.Controls.Add(tbPrice);
            AddProductPnl.Controls.Add(tbProductName);
            AddProductPnl.Controls.Add(lblDescription);
            AddProductPnl.Controls.Add(lblStockQuantity);
            AddProductPnl.Controls.Add(lblPrice);
            AddProductPnl.Controls.Add(lblProductName);
            AddProductPnl.Controls.Add(lblAddProductPnl);
            AddProductPnl.Location = new Point(12, 1);
            AddProductPnl.Name = "AddProductPnl";
            AddProductPnl.Size = new Size(1120, 255);
            AddProductPnl.TabIndex = 0;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(931, 215);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(155, 28);
            btnAddProduct.TabIndex = 12;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbCategory3);
            panel1.Controls.Add(cbCategory2);
            panel1.Controls.Add(lblCategories);
            panel1.Controls.Add(cbCategory1);
            panel1.Location = new Point(658, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 151);
            panel1.TabIndex = 11;
            // 
            // cbCategory3
            // 
            cbCategory3.AutoSize = true;
            cbCategory3.Location = new Point(17, 106);
            cbCategory3.Name = "cbCategory3";
            cbCategory3.Size = new Size(103, 24);
            cbCategory3.TabIndex = 12;
            cbCategory3.Tag = "3";
            cbCategory3.Text = "Category 3";
            cbCategory3.UseVisualStyleBackColor = true;
            // 
            // cbCategory2
            // 
            cbCategory2.AutoSize = true;
            cbCategory2.Location = new Point(17, 76);
            cbCategory2.Name = "cbCategory2";
            cbCategory2.Size = new Size(103, 24);
            cbCategory2.TabIndex = 11;
            cbCategory2.Tag = "2";
            cbCategory2.Text = "Category 2";
            cbCategory2.UseVisualStyleBackColor = true;
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Location = new Point(37, 7);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(69, 20);
            lblCategories.TabIndex = 9;
            lblCategories.Text = "Category";
            // 
            // cbCategory1
            // 
            cbCategory1.AutoSize = true;
            cbCategory1.Location = new Point(17, 46);
            cbCategory1.Name = "cbCategory1";
            cbCategory1.Size = new Size(103, 24);
            cbCategory1.TabIndex = 10;
            cbCategory1.Tag = "1";
            cbCategory1.Text = "Category 1";
            cbCategory1.UseVisualStyleBackColor = true;
            // 
            // tbStockQuantity
            // 
            tbStockQuantity.Location = new Point(211, 131);
            tbStockQuantity.Name = "tbStockQuantity";
            tbStockQuantity.Size = new Size(222, 27);
            tbStockQuantity.TabIndex = 8;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(211, 173);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(322, 27);
            tbDescription.TabIndex = 7;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(211, 88);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(222, 27);
            tbPrice.TabIndex = 6;
            // 
            // tbProductName
            // 
            tbProductName.Location = new Point(211, 49);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(222, 27);
            tbProductName.TabIndex = 5;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(53, 180);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description";
            // 
            // lblStockQuantity
            // 
            lblStockQuantity.AutoSize = true;
            lblStockQuantity.Location = new Point(52, 138);
            lblStockQuantity.Name = "lblStockQuantity";
            lblStockQuantity.Size = new Size(105, 20);
            lblStockQuantity.TabIndex = 3;
            lblStockQuantity.Text = "Stock Quantity";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(53, 95);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(53, 56);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(104, 20);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Product Name";
            // 
            // lblAddProductPnl
            // 
            lblAddProductPnl.AutoSize = true;
            lblAddProductPnl.Location = new Point(13, 9);
            lblAddProductPnl.Name = "lblAddProductPnl";
            lblAddProductPnl.Size = new Size(92, 20);
            lblAddProductPnl.TabIndex = 0;
            lblAddProductPnl.Text = "Add Product";
            // 
            // dgProducts
            // 
            dgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProducts.Location = new Point(12, 376);
            dgProducts.MultiSelect = false;
            dgProducts.Name = "dgProducts";
            dgProducts.RowHeadersWidth = 51;
            dgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProducts.Size = new Size(1120, 355);
            dgProducts.TabIndex = 1;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(65, 748);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(155, 28);
            btnUpdateProduct.TabIndex = 13;
            btnUpdateProduct.Text = "Update Product";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += this.btnUpdateProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(943, 748);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(155, 28);
            btnDeleteProduct.TabIndex = 14;
            btnDeleteProduct.Text = "Delete Product";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(65, 340);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(117, 20);
            lblSearch.TabIndex = 16;
            lblSearch.Text = "Search by Name";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(223, 336);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(322, 27);
            tbSearch.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(943, 336);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(155, 28);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 783);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Controls.Add(lblSearch);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnUpdateProduct);
            Controls.Add(dgProducts);
            Controls.Add(AddProductPnl);
            Name = "MainForm";
            Text = "MainForm";
            AddProductPnl.ResumeLayout(false);
            AddProductPnl.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel AddProductPnl;
        private Label lblDescription;
        private Label lblStockQuantity;
        private Label lblPrice;
        private Label lblProductName;
        private Label lblAddProductPnl;
        private TextBox tbStockQuantity;
        private TextBox tbDescription;
        private TextBox tbPrice;
        private TextBox tbProductName;
        private Panel panel1;
        private CheckBox cbCategory1;
        private Label lblCategories;
        private Button btnAddProduct;
        private CheckBox cbCategory3;
        private CheckBox cbCategory2;
        private DataGridView dgProducts;
        private Button btnUpdateProduct;
        private Button btnDeleteProduct;
        private Label lblSearch;
        private TextBox tbSearch;
        private Button btnSearch;
    }
}