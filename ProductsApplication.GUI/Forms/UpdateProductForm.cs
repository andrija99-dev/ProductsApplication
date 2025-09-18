using ProductsApplication.GUI.Helper;
using ProductsApplication.GUI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsApplication.GUI.Forms
{
    public partial class UpdateProductForm : Form
    {
        private readonly ProductDto _product;
        private readonly Action _refreshMainForm;

        public UpdateProductForm(ProductDto product, Action refreshMainForm)
        {
            InitializeComponent();
            _product = product;
            _refreshMainForm = refreshMainForm;

            LoadProductData();
        }

        private void LoadProductData()
        {
            tbProductNameUpdate.Text = _product.ProductName;
            tbPriceUpdate.Text = _product.Price.ToString();
            tbStockQuantityUpdate.Text = _product.StockQuantity.ToString();
            tbDescriptionUpdate.Text = _product.Description;

            cbCategory1Update.Checked = _product.Categories.Contains("Category One");
            cbCategory2Update.Checked = _product.Categories.Contains("Category Two");
            cbCategory3Update.Checked = _product.Categories.Contains("Category Three");

        }

        private async void btnAddProductUpdate_Click(object sender, EventArgs e)
        {
            var selectedCategories = new List<int>();
            if (cbCategory1Update.Checked) selectedCategories.Add(1);
            if (cbCategory2Update.Checked) selectedCategories.Add(2);
            if (cbCategory3Update.Checked) selectedCategories.Add(3);

            if (!ProductValidationHelper.Validate(tbProductNameUpdate.Text, tbPriceUpdate.Text, tbStockQuantityUpdate.Text, selectedCategories, out string error))
            {
                MessageBox.Show(error);
                return;
            }

            var dto = new CreateProductDto
            {
                ProductName = tbProductNameUpdate.Text,
                Price = decimal.Parse(tbPriceUpdate.Text),
                StockQuantity = int.Parse(tbStockQuantityUpdate.Text),
                Description = tbDescriptionUpdate.Text,
                CategoryIds = selectedCategories
            };

            var response = await ApiClient.Instance.PutAsJsonAsync($"api/products/{_product.ProductId}", dto);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Product Updated!");
                _refreshMainForm.Invoke();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error updating product");
            }

        }
    }
}
