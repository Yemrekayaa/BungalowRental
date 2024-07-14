using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentaCar.Dto.TestimonialDtos;

namespace RentaCar.WebUI.ViewComponents.TestimonialViewComponents
{
    public class _TestimonialComponentPartial: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _TestimonialComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(){
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5113/api/Testimonial");
            if (responseMessage.IsSuccessStatusCode){
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}