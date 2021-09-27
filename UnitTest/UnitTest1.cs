using System;
using HussmannDev.SDMCompulsory.Core.Models;
using HussmannDev.SDMCompulsory.Domain.IRepositories;
using Infrastructure.Mock;
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

            BEReviewRepository mService = new BEReviewRepository(m.Object);

            mService.GetNumberOfReviewsFromReviewer()
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