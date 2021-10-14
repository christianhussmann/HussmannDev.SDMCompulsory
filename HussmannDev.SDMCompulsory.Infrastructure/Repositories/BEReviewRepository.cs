using System;
using System.Collections.Generic;
using HussmannDev.SDMCompulsory.Core.Models;
using HussmannDev.SDMCompulsory.Domain.IRepositories;

namespace Infrastructure.Repositories
{
    public class BEReviewRepository
    {
        private List<BEReview> reviews = new List<BEReview>()
        {
            new BEReview {Grade = 5, Movie = 1, Reviewer = 1, ReviewDate = DateTime.Now.AddDays(10)},
            new BEReview {Grade = 4, Movie = 1, Reviewer = 2, ReviewDate = DateTime.Now},
            new BEReview {Grade = 2, Movie = 1, Reviewer = 3, ReviewDate = DateTime.Now.AddDays(-10)},
            new BEReview {Grade = 5, Movie = 1, Reviewer = 4, ReviewDate = DateTime.Now.AddDays(5)},
            new BEReview {Grade = 1, Movie = 2, Reviewer = 1, ReviewDate = DateTime.Now.AddDays(2)},
            new BEReview {Grade = 3, Movie = 2, Reviewer = 2, ReviewDate = DateTime.Now.AddDays(-50)},
            new BEReview {Grade = 4, Movie = 2, Reviewer = 3, ReviewDate = DateTime.Now.AddDays(20)},
            new BEReview {Grade = 3, Movie = 2, Reviewer = 4, ReviewDate = DateTime.Now.AddDays(-10)},
            new BEReview {Grade = 3, Movie = 3, Reviewer = 1, ReviewDate = DateTime.Now.AddDays(2)},
            new BEReview {Grade = 2, Movie = 3, Reviewer = 2, ReviewDate = DateTime.Now.AddDays(3)},
            new BEReview {Grade = 4, Movie = 3, Reviewer = 3, ReviewDate = DateTime.Now.AddDays(4)},
            new BEReview {Grade = 5, Movie = 3, Reviewer = 4, ReviewDate = DateTime.Now.AddDays(-2)},
            new BEReview {Grade = 4, Movie = 4, Reviewer = 1, ReviewDate = DateTime.Now.AddDays(2)},
            new BEReview {Grade = 3, Movie = 4, Reviewer = 2, ReviewDate = DateTime.Now.AddDays(-6)},
            new BEReview {Grade = 1, Movie = 4, Reviewer = 3, ReviewDate = DateTime.Now.AddDays(1)},
            new BEReview {Grade = 3, Movie = 4, Reviewer = 4, ReviewDate = DateTime.Now.AddDays(2)}
        };

        public IEnumerable<BEReview> GetAllReviews()
        {
            return reviews;
        }

        public BEReview GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(BEReview p)
        {
            throw new NotImplementedException();
        }

        public void Update(BEReview p)
        {
            throw new NotImplementedException();
        }

        public void Delete(BEReview p)
        {
            throw new NotImplementedException();
        }
    }
}