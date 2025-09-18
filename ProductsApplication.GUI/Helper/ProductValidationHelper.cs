using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApplication.GUI.Helper
{
    public static class ProductValidationHelper
    {
        public static bool Validate(string productName, string priceText, string stockText, List<int> selectedCategories, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(productName))
            {
                errorMessage = "Product Name is required!";
                return false;
            }

            if (!decimal.TryParse(priceText, out decimal price) || price <= 0)
            {
                errorMessage = "Price is required and must be greater than 0";
                return false;
            }

            if (!int.TryParse(stockText, out int stock) || stock <= 0)
            {
                errorMessage = "Stock Quantity is required and must be greater than 0";
                return false;
            }

            if (selectedCategories.Count == 0)
            {
                errorMessage = "Please select at least one category!";
                return false;
            }

            return true;
        }
    }
}
