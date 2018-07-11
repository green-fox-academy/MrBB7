using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MacrotisExam.Models
{
    public class Attractions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Price { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Category { get; set; }
        public int MyProperty { get; set; }
        public double Duration { get; set; }
        public int RecommendedAge { get; set; }
    }
}
