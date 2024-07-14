using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentaCar.Dto.ServiceDtos;

namespace RentaCar.WebUI.Controllers
{
    [Route("[controller]")]
    public class ServiceController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ServiceController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("http://localhost:5113/api/Service");
            if(response.IsSuccessStatusCode){
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);
                return View(values);
            }
            return View();
        }


    }
}