using WEBORIS.Models;

namespace WEBORIS.Interfaces
{
    public interface IReviewRepository
    {
        Task<IEnumerable<ReviewModel>> GetAllReview();
        Task<ReviewModel> GetReviewById(int id);
        bool Add(ReviewModel review);
        bool Update(ReviewModel review);
        bool Delete(ReviewModel review);
        bool Save();
    }
}
