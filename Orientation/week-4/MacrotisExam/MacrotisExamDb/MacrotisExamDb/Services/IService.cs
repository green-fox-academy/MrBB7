using MacrotisExamDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MacrotisExamDb.Services
{
    public interface IService
    {
        void AddAttraction(Attractions attraction);
        List<Attractions> GetAllAttractions();
        void UpdateAttraction(Attractions attraction);
        Attractions GetAnAttraction(int id);
        List<Attractions> GetAttractionsByCityAndCategory(string city, string category);
    }
}
