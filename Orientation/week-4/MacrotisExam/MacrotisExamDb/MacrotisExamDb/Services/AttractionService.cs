using MacrotisExamDb.Models;
using MacrotisExamDb.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MacrotisExamDb.Services
{
    public class AttractionService : IService
    {
        private AttractionsRepository attractionRepository;

        public AttractionService(AttractionsRepository attractionRepository)
        {
            this.attractionRepository = attractionRepository;
        }

        public void AddAttraction(Attractions attraction)
        {
            attractionRepository.Create(attraction);
        }

        public List<Attractions> GetAttractionsByCityAndCategory(string city, string category)
        {
            if (city != null && category != null)
            {
                return attractionRepository.Read()
                    .Where(x => x.City.ToLower().Contains(city)
                    && x.Category.ToLower().Contains(category)).ToList();
            }
            else if (city == null && category != null)
            {
                return attractionRepository.Read()
                    .Where(x => x.Category.ToLower().Contains(category))
                    .ToList();
            }
            else if (city != null && category == null)
            {
                return attractionRepository.Read()
                    .Where(x => x.City.ToLower().Contains(city))
                    .ToList();
            }
            else
            {
                return attractionRepository.Read().ToList();
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
