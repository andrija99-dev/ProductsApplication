namespace ProductsApplication.GUI.Forms
{
    partial class UpdateProductForm
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
            panel1 = new Panel();
            btnAddProductUpdate = new Button();
            panel2 = new Panel();
            cbCategory3Update = new CheckBox();
            cbCategory2Update = new CheckBox();
            lblCategories = new Label();
            cbCategory1Update = new CheckBox();
            tbStockQuantityUpdate = new TextBox();
            tbDescriptionUpdate = new TextBox();
            tbPriceUpdate = new TextBox();
            tbProductNameUpdate = new TextBox();
            lblDescription = new Label();
            lblStockQuantity = new Label();
            lblPrice = new Label();
            lblProductName = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddProductUpdate);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(tbStockQuantityUpdate);
            panel1.Controls.Add(tbDescriptionUpdate);
            panel1.Controls.Add(tbPriceUpdate);
            panel1.Controls.Add(tbProductNameUpdate);
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(lblStockQuantity);
            panel1.Controls.Add(lblPrice);
            panel1.Controls.Add(lblProductName);
            panel1.Location = new Point(84, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 354);
            panel1.TabIndex = 0;
            // 
            // btnAddProductUpdate
            // 
            btnAddProductUpdate.Location = new Point(332, 298);
            btnAddProductUpdate.Name = "btnAddProductUpdate";
            btnAddProductUpdate.Size = new Size(141, 28);
            btnAddProductUpdate.TabIndex = 21;
            btnAddProductUpdate.Text = "Save Changes";
            btnAddProductUpdate.UseVisualStyleBackColor = true;
            btnAddProductUpdate.Click += btnAddProductUpdate_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbCategory3Update);
            panel2.Controls.Add(cbCategory2Update);
            panel2.Controls.Add(lblCategories);
            panel2.Controls.Add(cbCategory1Update);
            panel2.Location = new Point(536, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(141, 151);
            panel2.TabIndex = 20;
            // 
            // cbCategory3Update
            // 
            cbCategory3Update.AutoSize = true;
            cbCategory3Update.Location = new Point(17, 106);
            cbCategory3Update.Name = "cbCategory3Update";
            cbCategory3Update.Size = new Size(103, 24);
            cbCategory3Update.TabIndex = 12;
            cbCategory3Update.Tag = "3";
            cbCategory3Update.Text = "Category 3";
            cbCategory3Update.UseVisualStyleBackColor = true;
            // 
            // cbCategory2Update
            // 
            cbCategory2Update.AutoSize = true;
            cbCategory2Update.Location = new Point(17, 76);
            cbCategory2Update.Name = "cbCategory2Update";
            cbCategory2Update.Size = new Size(103, 24);
            cbCategory2Update.TabIndex = 11;
            cbCategory2Update.Tag = "2";
            cbCategory2Update.Text = "Category 2";
            cbCategory2Update.UseVisualStyleBackColor = true;
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
            // cbCategory1Update
            // 
            cbCategory1Update.AutoSize = true;
            cbCategory1Update.Location = new Point(17, 46);
            cbCategory1Update.Name = "cbCategory1Update";
            cbCategory1Update.Size = new Size(103, 24);
            cbCategory1Update.TabIndex = 10;
            cbCategory1Update.Tag = "1";
            cbCategory1Update.Text = "Category 1";
            cbCategory1Update.UseVisualStyleBackColor = true;
            // 
            // tbStockQuantityUpdate
            // 
            tbStockQuantityUpdate.Location = new Point(177, 132);
            tbStockQuantityUpdate.Name = "tbStockQuantityUpdate";
            tbStockQuantityUpdate.Size = new Size(222, 27);
            tbStockQuantityUpdate.TabIndex = 19;
            // 
            // tbDescriptionUpdate
            // 
            tbDescriptionUpdate.Location = new Point(177, 174);
            tbDescriptionUpdate.Name = "tbDescriptionUpdate";
            tbDescriptionUpdate.Size = new Size(322, 27);
            tbDescriptionUpdate.TabIndex = 18;
            // 
            // tbPriceUpdate
            // 
            tbPriceUpdate.Location = new Point(177, 89);
            tbPriceUpdate.Name = "tbPriceUpdate";
            tbPriceUpdate.Size = new Size(222, 27);
            tbPriceUpdate.TabIndex = 17;
            // 
            // tbProductNameUpdate
            // 
            tbProductNameUpdate.Location = new Point(177, 50);
            tbProductNameUpdate.Name = "tbProductNameUpdate";
            tbProductNameUpdate.Size = new Size(222, 27);
            tbProductNameUpdate.TabIndex = 16;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(56, 181);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 15;
            lblDescription.Text = "Description";
            // 
            // lblStockQuantity
            // 
            lblStockQuantity.AutoSize = true;
            lblStockQuantity.Location = new Point(55, 139);
            lblStockQuantity.Name = "lblStockQuantity";
            lblStockQuantity.Size = new Size(105, 20);
            lblStockQuantity.TabIndex = 14;
            lblStockQuantity.Text = "Stock Quantity";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(56, 96);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 13;
            lblPrice.Text = "Price";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(56, 57);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(104, 20);
            lblProductName.TabIndex = 12;
            lblProductName.Text = "Product Name";
            // 
            // UpdateProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 425);
            Controls.Add(panel1);
            Name = "UpdateProductForm";
            Text = "UpdateProductForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private CheckBox cbCategory3Update;
        private CheckBox cbCategory2Update;
        private Label lblCategories;
        private CheckBox cbCategory1Update;
        private TextBox tbStockQuantityUpdate;
        private TextBox tbDescriptionUpdate;
        private TextBox tbPriceUpdate;
        private TextBox tbProductNameUpdate;
        private Label lblDescription;
        private Label lblStockQuantity;
        private Label lblPrice;
        private Label lblProductName;
        private Button btnAddProductUpdate;
    }
}