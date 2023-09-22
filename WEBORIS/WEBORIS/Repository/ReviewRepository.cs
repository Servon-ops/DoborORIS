using WEBORIS.Data;
using WEBORIS.Models;
using WEBORIS.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace WEBORIS.Repository
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly ApplicationDBContext _context;

        public ReviewRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public bool Add(ReviewModel review)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ReviewModel review)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ReviewModel>> GetAllReview()
        {
            return await _context.Reviews.ToListAsync();
        }

        public async Task<ReviewModel> GetReviewById(int id)
        {
            return await _context.Reviews.FindAsync(id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(ReviewModel review)
        {
            _context.Update(review);
            return Save();
        }
    }
}
