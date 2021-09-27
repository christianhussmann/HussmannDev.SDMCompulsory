using System;
using System.Collections.Generic;
using HussmannDev.SDMCompulsory.Core.IServices;
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
            {
                Mock<IBEReviewRepository> m = new Mock<IBEReviewRepository>();
                
                BEReview[] returnValue =
                {
                    new BEReview() {Reviewer = 1, Grade = 2, Movie = 1, ReviewDate = DateTime.Now},
                    new BEReview() {Reviewer = 1, Grade = 2, Movie = 2, ReviewDate = DateTime.Now},
                    new BEReview() {Reviewer = 1, Grade = 2, Movie = 3, ReviewDate = DateTime.Now},
                    new BEReview() {Reviewer = 1, Grade = 2, Movie = 4, ReviewDate = DateTime.Now},
                    new BEReview() {Reviewer = 1, Grade = 2, Movie = 5, ReviewDate = DateTime.Now},
                    new BEReview() {Reviewer = 1, Grade = 2, Movie = 6, ReviewDate = DateTime.Now},
                    new BEReview() {Reviewer = 2, Grade = 2, Movie = 7, ReviewDate = DateTime.Now}
                };
                m.Setup(m => m.GetAllReviews()).Returns(() => returnValue);
                
                BEReviewService mService = new BEReviewService(m.Object);
            
                //Act
                int actualResult = mService.GetNumberOfReviewsFromReviewer(1);
            
                //Assert
                m.Verify(m => m.GetAllReviews(), Times.Once);
            
                Assert.True(actualResult == 6);
            }
        }

        [Fact]
        public void GetAverageRateFromReviewer()
        {
            //Arrange
            Mock<IBEReviewRepository> m = new Mock<IBEReviewRepository>();

            BEReview[] returnValue =
            {
                new BEReview() {Reviewer = 1, Grade = 1, Movie = 1, ReviewDate = DateTime.Now},
                new BEReview() {Reviewer = 1, Grade = 1, Movie = 2, ReviewDate = DateTime.Now},
                new BEReview() {Reviewer = 1, Grade = 5, Movie = 3, ReviewDate = DateTime.Now},
                new BEReview() {Reviewer = 1, Grade = 3, Movie = 4, ReviewDate = DateTime.Now},
                new BEReview() {Reviewer = 1, Grade = 1, Movie = 5, ReviewDate = DateTime.Now},
                new BEReview() {Reviewer = 1, Grade = 1, Movie = 6, ReviewDate = DateTime.Now},
                new BEReview() {Reviewer = 1, Grade = 1, Movie = 7, ReviewDate = DateTime.Now},
            };
            m.Setup(m => m.GetAllReviews()).Returns(() => returnValue);

            BEReviewService mService = new BEReviewService(m.Object);
            
            //Act
            double actualResult = mService.GetAverageRateFromReviewer(1);
            
            //Assert
            m.Verify(m=> m.GetAllReviews(), Times.Once);
            
            Assert.True(actualResult == 1.85);
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
            
            mock.Verify(mock => mock.GetAllReviews(), Times.Once);
            
            Assert.True(actualResult == 3);
        }

        [Fact]
        public void GetNumberOfRates()
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

            double actualResult = _reviewService.GetNumberOfRates(2, 3);
            
            mock.Verify(mock => mock.GetAllReviews(), Times.Once);
            
            Assert.True(actualResult == 2);
        }

        [Fact]
        public void GetMostProductiveReviewers()
        {
            Mock<IBEReviewRepository> mock = new Mock<IBEReviewRepository>();

            BEReview[] returnValue =
            {
                new BEReview {Grade = 1, Movie = 2, Reviewer = 1, ReviewDate = DateTime.Now},
                new BEReview {Grade = 3, Movie = 2, Reviewer = 2, ReviewDate = DateTime.Now},
                new BEReview {Grade = 5, Movie = 2, Reviewer = 3, ReviewDate = DateTime.Now},
                new BEReview {Grade = 3, Movie = 2, Reviewer = 4, ReviewDate = DateTime.Now},
                new BEReview {Grade = 5, Movie = 3, Reviewer = 4, ReviewDate = DateTime.Now},
            };
            
            mock.Setup(mock => mock.GetAllReviews()).Returns(() => returnValue);

            BEReviewService _reviewService = new BEReviewService(mock.Object);

            List<int> actualResult = _reviewService.GetMostProductiveReviewers();

            mock.Verify(mock => mock.GetAllReviews(), Times.Once);

            Assert.Collection(actualResult,
                item => Assert.Equal(4, item),
                item => Assert.Equal(4, item),
                item => Assert.Equal(3, item),
                item => Assert.Equal(2, item),
                item => Assert.Equal(1, item));
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