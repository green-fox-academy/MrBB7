using RedditBackend.Entities;
using RedditBackend.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Repositories
{
    public class UserRepository : IGenericRepository<User>
    {
        private RedditBackendDbContext userDb;

        public UserRepository(RedditBackendDbContext userDb)
        {
            this.userDb = userDb;
        }

        public void Create(User element)
        {
            userDb.Add(element);
            userDb.SaveChanges();
        }

        public void Delete(User element)
        {
            userDb.Users.Remove(element);
            userDb.SaveChanges();
        }

        public List<User> Read()
        {
            return userDb.Users.ToList();
        }

        public void Update(User element)
        {
            userDb.Update(element);
            userDb.SaveChanges();
        }
    }
}
