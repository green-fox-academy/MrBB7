using RedditBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Services
{
    public interface IService
    {
        void AddPost(Post post);
        List<Post> GetAllPosts();
        void UpdatePost(Post post, int id);
        void DeleteAPost(int id);
        void UpVote(int id);
        void DownVote(int id);
        Post GetAPost(int id);
    }
}
