using RedditBackend.Entities;
using RedditBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Repositories
{
    public class PostRepository : IGenericRepository<Post>
    {
        private RedditBackendDbContext postDb;

        public PostRepository(RedditBackendDbContext postDb)
        {
            this.postDb = postDb;
        }

        public void Create(Post element)
        {
            postDb.Add(element);
            postDb.SaveChanges();
        }

        public void Delete(Post element)
        {
            postDb.Posts.Remove(element);
            postDb.SaveChanges();
        }

        public List<Post> Read()
        {
            return postDb.Posts.ToList();
        }

        public void Update(Post element)
        {
            postDb.Update(element);
            postDb.SaveChanges();
        }
    }
}
