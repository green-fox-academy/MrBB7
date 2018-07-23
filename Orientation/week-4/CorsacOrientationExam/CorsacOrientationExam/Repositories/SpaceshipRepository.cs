using CorsacOrientationExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorsacOrientationExam.Repositories
{
    public class SpaceshipRepository : IGenericRepository<Spaceship>
    {
        private CorsacOrientationExamContext dbContext;

        public SpaceshipRepository(CorsacOrientationExamContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Spaceship element)
        {
            dbContext.Spaceship.Add(element);
            dbContext.SaveChanges();
        }

        public void Delete(Spaceship element)
        {
            dbContext.Spaceship.Remove(element);
            dbContext.SaveChanges();
        }

        public List<Spaceship> Read()
        {
            return dbContext.Spaceship.ToList();
        }

        public void Update(Spaceship element)
        {
            dbContext.Spaceship.Update(element);
            dbContext.SaveChanges();
        }
    }
}
