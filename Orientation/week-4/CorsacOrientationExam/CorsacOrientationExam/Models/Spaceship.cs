using System;
using System.Collections.Generic;

namespace CorsacOrientationExam.Models
{
    public partial class Spaceship
    {
        public int Id { get; set; }
        public int MaxCapacity { get; set; }
        public string Planet { get; set; }
        public int Utilization { get; set; }
    }
}
