using System;
using System.Collections.Generic;
using HussmannDev.SDMCompulsory.Core.IServices;
using HussmannDev.SDMCompulsory.Core.Models;
using HussmannDev.SDMCompulsory.Domain.IRepositories;

namespace HussmannDev.SDMCompulsory.Domain.Services
{
    public class BEReviewService : IBEReviewService
    {
        private IBEReviewRepository _beReviewRepository;
        
        public BEReviewService(IBEReviewRepository beReviewRepository)
        {
            _beReviewRepository = beReviewRepository;
        }
        
        public int GetNumberOfReviewsFromReviewer(int reviewer)
        {
            throw new NotImplementedException();
        }

        public double GetAverageRateFromReviewer(int reviewer)
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfRatesByReviewer(int reviewer, int rate)
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfReviews(int movie)
        {
            throw new NotImplementedException();
        }

        public double GetAverageRateOfMovie(int movie)
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfRates(int movie, int rate)
        {
            throw new NotImplementedException();
        }

        public List<int> GetMoviesWithHighestNumberOfTopRates()
        {
            throw new NotImplementedException();
        }

        public List<int> GetMostProductiveReviewers()
        {
            throw new NotImplementedException();
        }

        public List<int> GetTopRatedMovies(int amount)
        {
            throw new NotImplementedException();
        }

        public List<int> GetTopMoviesByReviewer(int reviewer)
        {
            throw new NotImplementedException();
        }

        public List<int> GetReviewersByMovie(int movie)
        {
            throw new NotImplementedException();
        }
    }
}