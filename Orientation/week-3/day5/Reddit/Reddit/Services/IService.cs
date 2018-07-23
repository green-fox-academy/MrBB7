using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reddit.Models;

namespace Reddit.Services
{
    public interface IService
    {
        List<Post> GetAllPosts();
        void AddVote(int id);
        void SubstractVote(int id);
        void AddPost(Post post);
    }
}
