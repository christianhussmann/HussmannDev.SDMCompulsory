using System;
using System.Collections.Generic;
using HussmannDev.SDMCompulsory.Core.IServices;
using HussmannDev.SDMCompulsory.Core.Models;
using HussmannDev.SDMCompulsory.Domain.IRepositories;
using HussmannDev.SDMCompulsory.Domain.Services;
using Infrastructure.Repositories;
using Moq;
using Xunit;
using Xunit.Sdk;

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
            
            Assert.True(actualResult == (1+1+5+3+1+1+1)/7);
        }

        [Fact]
        public void GetNumberOfRatesByReviewer()
        {
            //Arrange
                Mock<IBEReviewRepository> m = new Mock<IBEReviewRepository>();

                BEReview[] returnValue =
                {
                    new BEReview() {Reviewer = 2, Grade = 3, Movie = 1, ReviewDate = DateTime.Now},
                    new BEReview() {Reviewer = 1, Grade = 3, Movie = 2, ReviewDate = DateTime.Now},
                    new BEReview() {Reviewer = 1, Grade = 3, Movie = 3, ReviewDate = DateTime.Now},
                    new BEReview() {Reviewer = 2, Grade = 3, Movie = 4, ReviewDate = DateTime.Now},
                    new BEReview() {Reviewer = 1, Grade = 3, Movie = 5, ReviewDate = DateTime.Now},
                    new BEReview() {Reviewer = 1, Grade = 4, Movie = 6, ReviewDate = DateTime.Now},
                    new BEReview() {Reviewer = 2, Grade = 3, Movie = 7, ReviewDate = DateTime.Now}
                };
                m.Setup(m => m.GetAllReviews()).Returns(() => returnValue);

                BEReviewService mService = new BEReviewService(m.Object);

                //Act
                double actualResult = mService.GetNumberOfRatesByReviewer(1, 3);

                //Assert
                m.Verify(m => m.GetAllReviews(), Times.Once);

                Assert.True(actualResult == 3);
            }
        

        [Fact]
        public void GetNumberOfReviews()
        {
            //Arrange
            Mock<IBEReviewRepository> m = new Mock<IBEReviewRepository>();

            BEReview[] returnValue =
            {
                new BEReview() {Reviewer = 1, Grade = 3, Movie = 1, ReviewDate = DateTime.Now},
                new BEReview() {Reviewer = 1, Grade = 2, Movie = 2, ReviewDate = DateTime.Now},
                new BEReview() {Reviewer = 1, Grade = 1, Movie = 2, ReviewDate = DateTime.Now},
                new BEReview() {Reviewer = 1, Grade = 5, Movie = 2, ReviewDate = DateTime.Now},
                new BEReview() {Reviewer = 1, Grade = 4, Movie = 5, ReviewDate = DateTime.Now},
                new BEReview() {Reviewer = 1, Grade = 2, Movie = 1, ReviewDate = DateTime.Now},
                new BEReview() {Reviewer = 1, Grade = 1, Movie = 2, ReviewDate = DateTime.Now},
            };
            m.Setup(m => m.GetAllReviews()).Returns(() => returnValue);

            BEReviewService mService = new BEReviewService(m.Object);
            
            //Act
            double actualResult = mService.GetNumberOfReviews(2);
            
            //Assert
            m.Verify(m => m.GetAllReviews(), Times.Once);
            
            Assert.True(actualResult == 4);
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
        public void GetMoviesWithHighestNumberOfTopRates()
        {
            Mock<IBEReviewRepository> mock = new Mock<IBEReviewRepository>();

            BEReview[] returnValue =
            {
                new BEReview {Grade = 5, Movie = 1, Reviewer = 1, ReviewDate = DateTime.Now},
                new BEReview {Grade = 3, Movie = 2, Reviewer = 2, ReviewDate = DateTime.Now},
                new BEReview {Grade = 5, Movie = 2, Reviewer = 3, ReviewDate = DateTime.Now},
                new BEReview {Grade = 3, Movie = 2, Reviewer = 4, ReviewDate = DateTime.Now},
                new BEReview {Grade = 5, Movie = 3, Reviewer = 4, ReviewDate = DateTime.Now},
            };
            
            mock.Setup(mock => mock.GetAllReviews()).Returns(() => returnValue);

            BEReviewService _reviewService = new BEReviewService(mock.Object);

            List<int> actualResult = _reviewService.GetMoviesWithHighestNumberOfTopRates();

            mock.Verify(mock => mock.GetAllReviews(), Times.Once);

            Assert.Collection(actualResult,
                item => Assert.Equal(1, item),
                item => Assert.Equal(2, item),
                item => Assert.Equal(3, item));
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
            //Arrange
            Mock<IBEReviewRepository> m = new Mock<IBEReviewRepository>();

            BEReview[] returnValue =
            {
                new BEReview {Grade = 5, Movie = 1, Reviewer = 1, ReviewDate = DateTime.Now.AddDays(10)},
                new BEReview {Grade = 4, Movie = 1, Reviewer = 2, ReviewDate = DateTime.Now},
                new BEReview {Grade = 2, Movie = 1, Reviewer = 3, ReviewDate = DateTime.Now.AddDays(-10)},
                new BEReview {Grade = 5, Movie = 1, Reviewer = 4, ReviewDate = DateTime.Now.AddDays(5)},
                new BEReview {Grade = 3, Movie = 3, Reviewer = 1, ReviewDate = DateTime.Now.AddDays(2)},
                new BEReview {Grade = 2, Movie = 3, Reviewer = 2, ReviewDate = DateTime.Now.AddDays(3)},
                new BEReview {Grade = 4, Movie = 3, Reviewer = 3, ReviewDate = DateTime.Now.AddDays(4)},
                new BEReview {Grade = 5, Movie = 3, Reviewer = 4, ReviewDate = DateTime.Now.AddDays(-2)},
                new BEReview {Grade = 4, Movie = 4, Reviewer = 1, ReviewDate = DateTime.Now.AddDays(2)},
                new BEReview {Grade = 5, Movie = 4, Reviewer = 2, ReviewDate = DateTime.Now.AddDays(-6)},
                new BEReview {Grade = 3, Movie = 4, Reviewer = 3, ReviewDate = DateTime.Now.AddDays(1)},
                new BEReview {Grade = 3, Movie = 4, Reviewer = 4, ReviewDate = DateTime.Now.AddDays(2)},
                //Value which not should be implemented
                new BEReview {Grade = 1, Movie = 2, Reviewer = 1, ReviewDate = DateTime.Now.AddDays(2)},
                new BEReview {Grade = 3, Movie = 2, Reviewer = 2, ReviewDate = DateTime.Now.AddDays(-50)},
                new BEReview {Grade = 4, Movie = 2, Reviewer = 3, ReviewDate = DateTime.Now.AddDays(20)},
                new BEReview {Grade = 3, Movie = 2, Reviewer = 4, ReviewDate = DateTime.Now.AddDays(-10)}
            };
            m.Setup(m => m.GetAllReviews()).Returns(() => returnValue);
            BEReviewService mService = new BEReviewService(m.Object);
            
            //Act
            List<int> actualResult = new List<int>(mService.GetTopRatedMovies(3));
            
            //Assert
            //movie 1 = 4, movie 2 = 2.75, movie 3 = 3.5, movie 4 = 3.75
            m.Verify(m => m.GetAllReviews(), Times.Once);
            Assert.Collection(actualResult,
                item => Assert.Equal(1, item),
                item => Assert.Equal(4, item),
                item => Assert.Equal(3, item));
        }

        
        [Fact]
        public void GetTopRatedMoviesExceptionTest()
        {
            //Arrange
            //Value which not should be implemented
            Mock<IBEReviewRepository> m = new Mock<IBEReviewRepository>();
            BEReviewService mService = new BEReviewService(m.Object);
            
            //Act
            //List<int> actualResult = new List<int>(mService.GetTopRatedMovies(0));
            mService.GetTopRatedMovies(0);
            //Assert
            var exception = Assert.Throws<Exception>(()=> mService.GetTopRatedMovies(0));
            Assert.Equal("Amount must be above 0.", exception.Message);
        }
        
        

        [Fact]
        public void GetTopMoviesByReviewer()
        {
            //Arrange
            Mock<IBEReviewRepository> m = new Mock<IBEReviewRepository>();

            BEReview[] returnValue =
            {
                //Sorting test Values
                new BEReview {Grade = 5, Movie = 1, Reviewer = 1, ReviewDate = DateTime.Now.AddDays(-10)},
                new BEReview {Grade = 5, Movie = 5, Reviewer = 1, ReviewDate = DateTime.Now.AddDays(-8)},
                new BEReview {Grade = 4, Movie = 6, Reviewer = 1, ReviewDate = DateTime.Now.AddDays(-6)},
                new BEReview {Grade = 4, Movie = 4, Reviewer = 1, ReviewDate = DateTime.Now.AddDays(-4)},
                new BEReview {Grade = 3, Movie = 3, Reviewer = 1, ReviewDate = DateTime.Now.AddDays(-9)},
                new BEReview {Grade = 1, Movie = 2, Reviewer = 1, ReviewDate = DateTime.Now.AddDays(-8)},
                
                //Mock which should not be implementet because the user is not 1
                new BEReview {Grade = 3, Movie = 3, Reviewer = 2, ReviewDate = DateTime.Now.AddDays(-9)},
                new BEReview {Grade = 1, Movie = 2, Reviewer = 6, ReviewDate = DateTime.Now.AddDays(-8)},
                
                
            };
            m.Setup(m => m.GetAllReviews()).Returns(() => returnValue);
            
            BEReviewService mService = new BEReviewService(m.Object);
            //Act
            List<int> actualResult = mService.GetTopMoviesByReviewer(1);
            //Assert
            m.Verify(m => m.GetAllReviews(), Times.Once);
            Assert.Collection(actualResult,
                item => Assert.Equal(1, item),
                item => Assert.Equal(5, item),
                
                item => Assert.Equal(6, item),
                
                item => Assert.Equal(4, item),
                
                item => Assert.Equal(3, item),
                item => Assert.Equal(2, item));
        }

        [Fact]
        public void GetReviewersByMovie()
        {
            //Arrange
            Mock<IBEReviewRepository> m = new Mock<IBEReviewRepository>();

            BEReview[] returnValue =
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
            m.Setup(m => m.GetAllReviews()).Returns(() => returnValue);
            BEReviewService mService = new BEReviewService(m.Object);
            
            //Act
            List<int> actualResult = mService.GetReviewersByMovie(2);
            
            //Assert
            m.Verify(m=> m.GetAllReviews(),Times.Once);
            Assert.Collection(actualResult,
                item=> Assert.Equal(1,item),
                item=> Assert.Equal(2,item),
                item=> Assert.Equal(3,item),
                item=> Assert.Equal(4,item));
        }
        
    }
}