using MacrotisExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MacrotisExam.Services
{
    public interface IService
    {
        void AddAttraction(Attractions attraction);
        List<Attractions> GetAllAttractions();
        void UpdateAttraction(Attractions attraction);
        List<Attractions> Filter(string category, string city);
        Attractions GetAnAttraction(int id);
    }
}
