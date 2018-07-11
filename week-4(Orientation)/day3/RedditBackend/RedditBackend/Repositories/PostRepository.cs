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

        public void Create(Post post)
        {
            postDb.Add(post);
            postDb.SaveChanges();
        }

        public void Delete(Post post)
        {
            postDb.Posts.Remove(post);
            postDb.SaveChanges();
        }

        public List<Post> Read()
        {
            return postDb.Posts.ToList();
        }

        public void Update(Post post)
        {
            postDb.Posts.Update(post);
            postDb.SaveChanges();
        }
    }
}
