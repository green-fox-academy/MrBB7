using System;
using System.Collections.Generic;

namespace MacrotisExamDb.Models
{
    public partial class Attractions
    {
        public int Id { get; set; }
        public string AttrName { get; set; }
        public string City { get; set; }
        public string Category { get; set; }
        public int? Price { get; set; }
        public double? Longitude { get; set; }
        public double? Lattitude { get; set; }
        public double? RecommendedAge { get; set; }
        public int? Duration { get; set; }
    }
}
