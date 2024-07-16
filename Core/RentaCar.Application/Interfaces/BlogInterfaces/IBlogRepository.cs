using RentaCar.Domain.Entities;

namespace RentaCar.Application.Interfaces.BlogInterfaces
{
    public interface IBlogRepository
    {
        Task<List<Blog>> GetLast3BlogWithAuthor();
    }
}