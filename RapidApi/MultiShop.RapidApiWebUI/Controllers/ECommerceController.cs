using Microsoft.AspNetCore.Mvc;
using MultiShop.RapidApiWebUI.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MultiShop.RapidApiWebUI.Controllers
{
    public class ECommerceController : Controller
    {
        public async Task<IActionResult> ECommerceList()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://real-time-product-search.p.rapidapi.com/search?q=Logitech%20fare&country=tr&language=en&page=1&limit=10&sort_by=BEST_MATCH&product_condition=ANY&min_rating=ANY"),
                Headers =
                {
                    { "x-rapidapi-key", "07511d7c58msh5300238c0843426p153e37jsn48d54f8176b2" },
                    { "x-rapidapi-host", "real-time-product-search.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                var apiResponse = JsonConvert.DeserializeObject<ECommerceViewModel.RootObject>(body);

                var products = apiResponse?.data?.products ?? new List<ECommerceViewModel.Product>();

                return View(products);
            }
        }
    }
}
