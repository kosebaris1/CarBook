using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.BlogInterfaces
{
    public interface IBlogRepository
    {
        Task<List<Blog>> GetLast3BlogsWithAuthor();
        Task<List<Blog>> GetAllBlogsWithAuthor();

        Task<List<Blog>> GetBlogsByAuthorId(int id);
    }
}
