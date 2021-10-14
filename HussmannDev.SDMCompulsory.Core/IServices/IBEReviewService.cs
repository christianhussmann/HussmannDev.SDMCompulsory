using System.Collections.Generic;
using HussmannDev.SDMCompulsory.Core.Models;

namespace HussmannDev.SDMCompulsory.Core.IServices
{
    public interface IBEReviewService
    {
        IEnumerable<BEReview> GetAllReviews();
        int GetNumberOfReviewsFromReviewer(int reviewer);
        double GetAverageRateFromReviewer(int reviewer);
        int GetNumberOfRatesByReviewer(int reviewer, int rate);
        int GetNumberOfReviews(int movie);
        double GetAverageRateOfMovie(int movie);
        int GetNumberOfRates(int movie, int rate);
        List<int> GetMoviesWithHighestNumberOfTopRates();
        List<int> GetMostProductiveReviewers();
        List<int> GetTopRatedMovies(int amount);
        List<int> GetTopMoviesByReviewer(int reviewer);
        List<int> GetReviewersByMovie(int movie);

        
        
    }
}