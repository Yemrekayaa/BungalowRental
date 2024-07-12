
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentaCar.Dto.AboutDtos;

namespace RentaCar.WebUI.VievComponents
{
    
    public class _AboutUsComponentPartial: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutUsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(){
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5113/api/About");
            if (responseMessage.IsSuccessStatusCode){
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);
                return View(results);
            }
            return View();
        }
    }
}