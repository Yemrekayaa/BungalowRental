using Microsoft.EntityFrameworkCore;
using RentaCar.Application.Interfaces.BlogInterfaces;
using RentaCar.Domain.Entities;
using RentaCar.Persistence.Context;

namespace RentaCar.Persistence.Repositories.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly RentaCarContext _context;

        public BlogRepository(RentaCarContext context)
        {
            _context = context;
        }

        public async Task<List<Blog>> GetBlogWithAuthor()
        {
            var values = await _context.Blogs.Include(x => x.Author).Include(x => x.Category).ToListAsync();
            return values;
        }

        public async Task<List<Blog>> GetLast3BlogWithAuthor()
        {
            var values = await _context.Blogs.Include(x => x.Author).OrderByDescending(x => x.Id).Take(3).ToListAsync();
            return values;
        }
    }
}