using System;
using System.Collections.Generic;
using System.Linq;
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
            int numberOfReviews = 0;
            foreach (var r in _beReviewRepository.GetAllReviews())
            {
                if (r.Reviewer == reviewer)
                {
                    numberOfReviews++;
                }
            }
            
            return numberOfReviews;
        }

        public double GetAverageRateFromReviewer(int reviewer)
        {
            int sum = 0;
            int numberOfReviews = 0;

            var userRatings = _beReviewRepository.GetAllReviews().Where(r => r.Reviewer == reviewer).ToList();
            

            foreach (var r in userRatings)
            {
                sum += r.Grade;
                numberOfReviews++;
            }

            return sum / numberOfReviews;
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
            int sum = 0;
            int numberOfReviews = 0;

            foreach (BEReview review in _beReviewRepository.GetAllReviews())
            {
                if (review.Movie == movie)
                {
                    sum += review.Grade;
                    numberOfReviews++;
                }
            }
            return sum / numberOfReviews;
        }

        public int GetNumberOfRates(int movie, int rate)
        {
            int result = 0;

            foreach (BEReview review in _beReviewRepository.GetAllReviews())
            {
                if (review.Movie == movie && review.Grade == rate)
                {
                    result++;
                }
            }

            return result;
        }
        

        public List<int> GetMoviesWithHighestNumberOfTopRates()
        {
            List<int> movies = new List<int>();

            foreach (var review in _beReviewRepository.GetAllReviews())
            {
                if (review.Grade == 5)
                {
                    movies.Add(review.Movie);
                }
            }
            
            return movies;
        }

        public List<int> GetMostProductiveReviewers()
        {
            List<int> reviewers = new List<int>();

            foreach (BEReview review in _beReviewRepository.GetAllReviews())
            {
                reviewers.Add(review.Reviewer);
            }
            
            reviewers.Sort();
            reviewers.Reverse();
            return reviewers;
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