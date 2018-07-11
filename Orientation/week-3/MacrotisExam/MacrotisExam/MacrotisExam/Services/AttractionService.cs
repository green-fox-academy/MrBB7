using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MacrotisExam.Models;
using MacrotisExam.Repositories;

namespace MacrotisExam.Services
{
    public class AttractionService : IService
    {
        private AttractionRepository attractionRepository;

        public AttractionService(AttractionRepository attractionRepository)
        {
            this.attractionRepository = attractionRepository;
        }

        public void AddAttraction(Attractions attraction)
        {
            attractionRepository.Create(attraction);
        }

        public List<Attractions> Filter(string category, string city)
        {
            List<Attractions> filteredAttraction = attractionRepository.Read().Where(x => x.Category.ToLower().Contains(category.ToLower()) && x.City.ToLower().Contains(city.ToLower())).ToList();

            if (filteredAttraction.Count == 0)
            {
                return GetAllAttractions();
            }
            else
            {
                return filteredAttraction;
            }
        }

        public List<Attractions> GetAllAttractions()
        {
            return attractionRepository.Read();
        }

        public Attractions GetAnAttraction(int id)
        {
            return attractionRepository.Read().FirstOrDefault(x => x.Id == id);
        }

        public void UpdateAttraction(Attractions attraction)
        {
            attractionRepository.Update(attraction);
        }
    }
}
