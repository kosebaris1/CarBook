using DTO.AuthorDtos;
using DTO.TagCloudDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarWebUI.ViewComponents.BlogsViewComponents
{
    public class _BlogDetailsAuthorAboutComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _BlogDetailsAuthorAboutComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.BlogId = id;
           var client= _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7008/api/Blog/GetBlogByAuthorId?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetAuthorByBlogAuthorIdDto>(jsonData);
                return View(values);
            }
            else
            {
                return View(Enumerable.Empty<GetAuthorByBlogAuthorIdDto>());
            }
        }
    }

}
