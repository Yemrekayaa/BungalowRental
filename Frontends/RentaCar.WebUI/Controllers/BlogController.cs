using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentaCar.Dto.BlogDtos;

namespace RentaCar.WebUI.Controllers
{
    [Route("[controller]")]
    public class BlogController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BlogController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "Blog";
            ViewBag.v2 = "Our Blog";
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("http://localhost:5113/api/Blog/GetBlogWithAuthor");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBlogWithAuthorDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet("BlogDetail")]
        public async Task<IActionResult> BlogDetail()
        {
            ViewBag.v1 = "Blog";
            ViewBag.v2 = "Read Our Blog";
            return View();
        }

        [HttpGet("BlogDetail/{id}")]
        public async Task<IActionResult> BlogDetail(int id)
        {
            ViewBag.v1 = "Blog";
            ViewBag.v2 = "Read Our Blog";
            return View();
        }


    }
}