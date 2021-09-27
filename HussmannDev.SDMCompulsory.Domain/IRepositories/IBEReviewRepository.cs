using System.Collections.Generic;
using HussmannDev.SDMCompulsory.Core.Models;

namespace HussmannDev.SDMCompulsory.Domain.IRepositories
{
    public interface IBEReviewRepository
    {
        IEnumerable<BEReview> GetAllReviews();
    }
}