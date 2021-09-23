using System.Collections.Generic;
using HussmannDev.SDMCompulsory.Domain.IRepositories;

namespace HussmannDev.SDMCompulsory.Domain.Services
{
    public class BEReviewService : IBEReviewRepository
    {
        private IBEReviewRepository _beReviewRepository;
        
        public BEReviewService(IBEReviewRepository beReviewRepository)
        {
            _beReviewRepository = beReviewRepository;
        }
        
        public int GetNumberOfReviewsFromReviewer(int reviewer)
        {
            return _beReviewRepository.GetNumberOfReviewsFromReviewer(reviewer);
        }

        public double GetAverageRateFromReviewer(int reviewer)
        {
            return _beReviewRepository.GetAverageRateFromReviewer(reviewer);
        }

        public int GetNumberOfRatesByReviewer(int reviewer, int rate)
        {
            return _beReviewRepository.GetNumberOfRatesByReviewer(reviewer, rate);
        }

        public int GetNumberOfReviews(int movie)
        {
            return _beReviewRepository.GetNumberOfReviews(movie);
        }

        public double GetAverageRateOfMovie(int movie)
        {
            return _beReviewRepository.GetAverageRateOfMovie(movie);
        }

        public int GetNumberOfRates(int movie, int rate)
        {
            return _beReviewRepository.GetNumberOfRates(movie, rate);
        }

        public List<int> GetMoviesWithHighestNumberOfTopRates()
        {
            return _beReviewRepository.GetMoviesWithHighestNumberOfTopRates();
        }

        public List<int> GetMostProductiveReviewers()
        {
            return _beReviewRepository.GetMostProductiveReviewers();
        }

        public List<int> GetTopRatedMovies(int amount)
        {
            return _beReviewRepository.GetTopRatedMovies(amount);
        }

        public List<int> GetTopMoviesByReviewer(int reviewer)
        {
            return _beReviewRepository.GetTopMoviesByReviewer(reviewer);
        }

        public List<int> GetReviewersByMovie(int movie)
        {
            return _beReviewRepository.GetReviewersByMovie(movie);
        }
    }
}