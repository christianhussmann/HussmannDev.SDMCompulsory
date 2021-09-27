using System;

namespace HussmannDev.SDMCompulsory.Core.Models
{
    public class BEReview
    {
        public int Reviewer { get; set; }
        public int Movie { get; set; }
        public int Grade { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}