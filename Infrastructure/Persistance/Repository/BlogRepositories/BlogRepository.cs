using Application.Interfaces.BlogInterfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repository.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly CarBookContext _context;

        public BlogRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<List<Blog>> GetAllBlogsWithAuthor()
        {
            var values= await _context.Blogs
                .Include(x => x.Author)
                .ToListAsync();
            return values;
        }

        public Task<List<Blog>> GetLast3BlogsWithAuthor()
        {
           var values= _context.Blogs
                .Include(x=>x.Author) 
                .OrderByDescending(x => x.BlogId)
                .Take(3)
                .ToListAsync();

            return values;
        }
    }
}
