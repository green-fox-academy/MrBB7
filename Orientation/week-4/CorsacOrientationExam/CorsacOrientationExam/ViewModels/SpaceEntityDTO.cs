using CorsacOrientationExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorsacOrientationExam.ViewModels
{
    public class SpaceEntityDTO
    {
        public List<Planet> Planets { get; set; }
        public Spaceship Spaceship { get; set; }
    }
}
