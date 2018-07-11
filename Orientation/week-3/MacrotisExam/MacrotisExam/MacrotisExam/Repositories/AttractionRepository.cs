using MacrotisExam.Entities;
using MacrotisExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MacrotisExam.Repositories
{
    public class AttractionRepository : IGenericRepository<Attractions>
    {
        private AttractionsDbContext attractionsDb;

        public AttractionRepository(AttractionsDbContext attractionsDb)
        {
            this.attractionsDb = attractionsDb;
        }

        public void Create(Attractions element)
        {
            attractionsDb.Add(element);
            attractionsDb.SaveChanges();
        }

        public void Delete(Attractions element)
        {
            attractionsDb.Attractions.Remove(element);
            attractionsDb.SaveChanges();
        }

        public List<Attractions> Read()
        {
            return attractionsDb.Attractions.ToList();
        }

        public void Update(Attractions element)
        {
            attractionsDb.Attractions.Update(element);
            attractionsDb.SaveChanges();
        }
    }
}
