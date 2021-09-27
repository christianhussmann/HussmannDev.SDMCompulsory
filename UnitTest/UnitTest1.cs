using System;
using HussmannDev.SDMCompulsory.Core.Models;
using HussmannDev.SDMCompulsory.Domain.IRepositories;
using HussmannDev.SDMCompulsory.Domain.Services;
using Infrastructure.Repositories;
using Moq;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            
        }

        [Fact]
        public void GetNumberOfReviewsFromReviewer()
        {
            Mock<IBEReviewRepository> m = new Mock<IBEReviewRepository>();

            //BEReviewRepository mService = new BEReviewRepository(m.Object);

            //mService.GetNumberOfReviewsFromReviewer();
        }

        [Fact]
        public void GetAverageRateFromReviewer()
        {
            
        }

        [Fact]
        public void GetNumberOfRatesByReviewer()
        {
            
        }

        [Fact]
        public void GetNumberOfReviews()
        {
            
        }
        
        [Fact]
        public void GetAverageRateOfMovie()
        {
            Mock<IBEReviewRepository> mock = new Mock<IBEReviewRepository>();

            BEReview[] returnValue =
            {
                new BEReview {Grade = 1, Movie = 2, Reviewer = 1, ReviewDate = DateTime.Now},
                new BEReview {Grade = 3, Movie = 2, Reviewer = 2, ReviewDate = DateTime.Now},
                new BEReview {Grade = 5, Movie = 2, Reviewer = 3, ReviewDate = DateTime.Now},
                new BEReview {Grade = 3, Movie = 2, Reviewer = 4, ReviewDate = DateTime.Now},
            };

            mock.Setup(mock => mock.GetAllReviews()).Returns(() => returnValue);

            BEReviewService _reviewService = new BEReviewService(mock.Object);

            double actualResult = _reviewService.GetAverageRateOfMovie(2);
        }

        [Fact]
        public void GetTopRatedMovies()
        {
            
        }

        [Fact]
        public void GetTopMoviesByReviewer()
        {
            
        }

        [Fact]
        public void GetReviewersByMovie()
        {
            
        }
        
    }
}