using System;
using System.Collections.Generic;
using HussmannDev.SDMCompulsory.Core.Models;

namespace Infrastructure.Mock
{
    public class MockData
    {
        private List<BEReview> reviews = new List<BEReview>()
        {
            new BEReview {Grade = 6, Movie = 1, Reviewer = 1, ReviewDate = DateTime.Now.AddDays(10)},
            new BEReview {Grade = 4, Movie = 1, Reviewer = 2, ReviewDate = DateTime.Now},
            new BEReview {Grade = 2, Movie = 1, Reviewer = 3, ReviewDate = DateTime.Now.AddDays(-10)},
            new BEReview {Grade = 7, Movie = 1, Reviewer = 4, ReviewDate = DateTime.Now.AddDays(5)},
            new BEReview {Grade = 5, Movie = 2, Reviewer = 1, ReviewDate = DateTime.Now.AddDays(2)},
            new BEReview {Grade = 7, Movie = 2, Reviewer = 2, ReviewDate = DateTime.Now.AddDays(-50)},
            new BEReview {Grade = 9, Movie = 2, Reviewer = 3, ReviewDate = DateTime.Now.AddDays(20)},
            new BEReview {Grade = 8, Movie = 2, Reviewer = 4, ReviewDate = DateTime.Now.AddDays(-10)},
            new BEReview {Grade = 3, Movie = 3, Reviewer = 1, ReviewDate = DateTime.Now.AddDays(2)},
            new BEReview {Grade = 2, Movie = 3, Reviewer = 2, ReviewDate = DateTime.Now.AddDays(3)},
            new BEReview {Grade = 4, Movie = 3, Reviewer = 3, ReviewDate = DateTime.Now.AddDays(4)},
            new BEReview {Grade = 5, Movie = 3, Reviewer = 4, ReviewDate = DateTime.Now.AddDays(-2)},
            new BEReview {Grade = 4, Movie = 4, Reviewer = 1, ReviewDate = DateTime.Now.AddDays(2)},
            new BEReview {Grade = 3, Movie = 4, Reviewer = 2, ReviewDate = DateTime.Now.AddDays(-6)},
            new BEReview {Grade = 1, Movie = 4, Reviewer = 3, ReviewDate = DateTime.Now.AddDays(1)},
            new BEReview {Grade = 3, Movie = 4, Reviewer = 4, ReviewDate = DateTime.Now.AddDays(2)}
        };

        private IEnumerable<BEReview> GetAllReviews()
        {
            return reviews;
        }
    }
}