using System.Collections.Generic;
using HussmannDev.SDMCompulsory.Core.Models;

namespace HussmannDev.SDMCompulsory.Domain.IRepositories
{
    public interface IBEReviewRepository
    {
        IEnumerable<BEReview> GetAllReviews();

        BEReview GetById(int id);

        void Insert(BEReview p);

        void Update(BEReview p);

        void Delete(BEReview p);
    }
}