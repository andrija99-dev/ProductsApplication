using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApplication.GUI.Helper
{
    public class ApiClient
    {
        private static readonly HttpClient _instance = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5009")
        };

        private ApiClient()
        {
        }
        public static HttpClient Instance => _instance;
    }
}
