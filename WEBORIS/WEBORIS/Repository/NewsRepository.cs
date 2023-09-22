using Microsoft.EntityFrameworkCore;
using WEBORIS.Data;
using WEBORIS.Interfaces;
using WEBORIS.Models;

namespace WEBORIS.Repository
{
    public class NewsRepository : INewsRepository {
        private readonly ApplicationDBContext _context;

    public NewsRepository(ApplicationDBContext context)
    {
        _context = context;
    }

    public bool Add(NewsModel news)
    {
        throw new NotImplementedException();
    }

    public bool Delete(NewsModel news)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<NewsModel>> GetAllNews()
    {
        return await _context.News.ToListAsync();
    }

    public async Task<NewsModel> GetNewsById(int id)
    {
            return await _context.News.FindAsync(id);
    }

    public bool Save()
    {
        var saved = _context.SaveChanges();
        return saved > 0 ? true : false;
    }

    public bool Update(NewsModel news)
    {
        _context.Update(news);
        return Save();
    }
    }
}
