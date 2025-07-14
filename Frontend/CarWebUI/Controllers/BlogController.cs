using DTO.BlogDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarWebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BlogController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.V1 = "Blog";
            ViewBag.V2 = "Bloglarımızı İnceleyin";
            var client = _httpClientFactory.CreateClient();
            var responseMessage =await client.GetAsync("https://localhost:7008/api/Blog/GetAllBlogsWithAuthor");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values= JsonConvert.DeserializeObject<List<ResultGetAllBlogsWithAuthorsDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> BlogDetail(int id)
        {
            ViewBag.V1 = "Blog Detay";
            ViewBag.V2 = "Blog Detaylarımızı İnceleyin";
            return View();
        }
    }
}
