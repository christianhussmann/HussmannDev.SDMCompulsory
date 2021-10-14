using System;
using HussmannDev.SDMCompulsory.Core.IServices;
using HussmannDev.SDMCompulsory.Core.Models;
using Infrastructure.Repositories;

namespace ConsoleApp
{
    class Program
    {
        private IBEReviewService _service;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public Program(IBEReviewService beReviewService)
        {
            _service = beReviewService;
        }

        public void PrintAllReviews()
        {
            foreach (BEReview review in _service.GetAllReviews())
            {
                Console.WriteLine(review.Movie + " " + review.Grade + " " + review.Reviewer + " " + review.ReviewDate);
            }
        }
    }
}