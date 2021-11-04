using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
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
            int numberOfRates = 0;
            foreach (var r in _beReviewRepository.GetAllReviews().Where(r => r.Reviewer == reviewer))
            {
                if (r.Grade == rate)
                {
                    numberOfRates++;
                }
            }

            return numberOfRates;
        }

        public int GetNumberOfReviews(int movie)
        {
            if (movie < 1)
            {
                throw new ArgumentException("Invalid input chief!");
            }

            return _beReviewRepository.GetAllReviews().Where(r => r.Movie == movie).ToList().Count;
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
            //liste med BEReviews
            List<BEReview> movies = new List<BEReview>();
            foreach (var m in _beReviewRepository.GetAllReviews())
            {
                movies.Add(m);
            }

            //making an dictonary where key is the movie and value the average rating
            Dictionary<int, double> averageRating = new Dictionary<int, double>();
            
            foreach (var m in movies)
            {
                try
                {
                    double d = 00.00;
                    if (averageRating.TryGetValue(m.Movie, out d))
                    {
                        d = (d + m.Grade) ;
                        averageRating.Remove(m.Movie);
                        averageRating.Add(m.Movie, d);
                    }
                    else 
                        averageRating.Add(m.Movie, m.Grade);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                
            }

            //Sort the dictonary by the value.
            var myList = averageRating.ToList();
            
            myList.Sort((pair2, pair1) => pair1.Value.CompareTo(pair2.Value));
            
            //List the movies sorted by their average review.
            List<int> anotherList = new List<int>();
            
            foreach (var m in myList)
            {
                anotherList.Add(m.Key);
            }
            

            //Transforming the list to an list with the element size of "amount"
            List<int> finalList = new List<int>();
            
            for (int i = 0; i < amount; i++)
            {
                finalList.Add(anotherList[i]);
            }
            return finalList;
        }

        public List<int> GetTopMoviesByReviewer(int reviewer)
        {
            List<BEReview> reviewedVideos = new List<BEReview>();
            foreach (var m in _beReviewRepository.GetAllReviews())
            {
                if (m.Reviewer.Equals(reviewer))
                {
                    reviewedVideos.Add(m);
                }
            }
            
            reviewedVideos.OrderByDescending(x => x.Grade)
                .ThenBy(x => x.ReviewDate).ToList();
            
           List<int> moviesSortedByRatingAndDate = new List<int>();

            foreach (var m in reviewedVideos)
            {
                moviesSortedByRatingAndDate.Add(m.Movie);
            }
            
            
            return moviesSortedByRatingAndDate;
        }

        public List<int> GetReviewersByMovie(int movie)
        {
            List<int> movieReviewer = new List<int>();
            
            foreach (var m in _beReviewRepository.GetAllReviews())
            {
                if (m.Movie.Equals(movie))
                {
                    movieReviewer.Add(m.Reviewer);
                }
            }
            return movieReviewer;
        }
    }
}