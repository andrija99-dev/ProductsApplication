using ProductsApplication.GUI.Forms;
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

namespace ProductsApplication.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Task.Run(async () => await LoadProductsWithRetry())
                .GetAwaiter().GetResult();
        }

        private async Task LoadProductsWithRetry(string searchName = null, int retries = 5, int delayMs = 1000)
        {
            for(int i = 0; i < retries; i++)
            {
                try
                {
                    await LoadProducts(searchName);
                    return;
                }
                catch (HttpRequestException)
                {
                    await Task.Delay(delayMs);
                }
            }

            MessageBox.Show("Cannot connect to backend. Please make sure it is running.");
        }

        private async Task LoadProducts(string searchName = null)
        {
            string url = "api/products";
            if (!string.IsNullOrEmpty(searchName))
            {
                url += $"?name={Uri.EscapeDataString(searchName)}";
            }
            var response = await ApiClient.Instance.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var products = await response.Content.ReadFromJsonAsync<List<ProductDto>>();
                dgProducts.DataSource = products;

                if (dgProducts.Columns["ProductId"] != null)
                {
                    dgProducts.Columns["ProductId"].Visible = false;
                }

                if (dgProducts.Columns["CategoriesDisplay"] != null)
                {
                    dgProducts.Columns["CategoriesDisplay"].HeaderText = "Categories";
                }

            }

            else
            {
                MessageBox.Show("Error loading products");
            }
        }

        private async void btnAddProduct_Click(object sender, EventArgs e)
        {
            List<int> selectedCategories = new List<int>();
            if (cbCategory1.Checked) selectedCategories.Add(1);
            if (cbCategory2.Checked) selectedCategories.Add(2);
            if (cbCategory3.Checked) selectedCategories.Add(3);

            if (!ProductValidationHelper.Validate(tbProductName.Text, tbPrice.Text, tbStockQuantity.Text, selectedCategories, out string error))
            {
                MessageBox.Show(error);
                return;
            }

            var dto = new CreateProductDto
            {
                ProductName = tbProductName.Text,
                Price = decimal.Parse(tbPrice.Text),
                StockQuantity = int.Parse(tbStockQuantity.Text),
                Description = tbDescription.Text,
                CategoryIds = selectedCategories
            };            

            var response = await ApiClient.Instance.PostAsJsonAsync("api/products", dto);
            if (response.IsSuccessStatusCode)
            {
                await LoadProducts();
                ClearInput();
                MessageBox.Show("Product Added!");
            }
            else
            {
                MessageBox.Show("Error loading products");
            }
        }

        private void ClearInput()
        {
            tbProductName.Clear();
            tbPrice.Clear();
            tbStockQuantity.Clear();
            tbDescription.Clear();
            cbCategory1.Checked = false;
            cbCategory2.Checked = false;
            cbCategory3.Checked = false;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await LoadProducts(tbSearch.Text);
        }

        private async void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if(dgProducts.CurrentRow != null)
            {
                int id = (int)dgProducts.CurrentRow.Cells["ProductId"].Value;
                var response = await ApiClient.Instance.DeleteAsync($"api/products/{id}");
                if (response.IsSuccessStatusCode)
                {
                    await LoadProducts();
                    MessageBox.Show("Product Deleted!");
                }
                else
                {
                    MessageBox.Show("Error deleting products");
                }
            }
        }

        private async void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (dgProducts.CurrentRow != null)
            {
                var product = (ProductDto)dgProducts.CurrentRow.DataBoundItem;
                if(product == null)
                {
                    return;
                }
                var updateForm = new UpdateProductForm(product, async() => await LoadProducts());
                updateForm.ShowDialog();
            }

            else
            {
                MessageBox.Show("Select a Product before Updating it");
            }
        }
    }
}
