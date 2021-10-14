using System.Collections.Generic;
using System.IO;
using HussmannDev.SDMCompulsory.Core.Models;
using HussmannDev.SDMCompulsory.Domain.IRepositories;
using Newtonsoft.Json;

namespace Infrastructure.Repositories
{
    public class BEReviewRepositoryFileReader : IBEReviewRepository
    {
        private readonly string _path = "../../../../ratings.json";

        public BEReviewRepositoryFileReader()
        {
            GetReviewsFromFile(_path);
        }
        
        private IEnumerable<BEReview> _ratingCollection;

        public void GetReviewsFromFile(string _path)
        {
            using (StreamReader streamReader = File.OpenText(_path))
            using (JsonTextReader reader = new JsonTextReader(streamReader))
            {
                reader.CloseInput = true;
                var serializer = new JsonSerializer();
                var ratings = new List<BEReview>();

                while (reader.Read())
                {
                    if (reader.TokenType == JsonToken.StartObject)
                    {
                        BEReview review = serializer.Deserialize<BEReview>(reader);
                        ratings.Add(review);
                    }

                }
                _ratingCollection = ratings;
            }
        }
        
        public IEnumerable<BEReview> GetAllReviews()
        {
            return _ratingCollection;
        }

        public BEReview GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(BEReview p)
        {
            throw new System.NotImplementedException();
        }

        public void Update(BEReview p)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(BEReview p)
        {
            throw new System.NotImplementedException();
        }
    }
}