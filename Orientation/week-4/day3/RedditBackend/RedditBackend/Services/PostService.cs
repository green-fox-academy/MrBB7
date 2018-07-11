using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RedditBackend.Models;
using RedditBackend.Repositories;

namespace RedditBackend.Services
{
    public class PostService : IService
    {
        private PostRepository postsRepo;

        public PostService(PostRepository postsRepo)
        {
            this.postsRepo = postsRepo;
        }

        public void AddPost(Post post)
        {
            postsRepo.Create(post);
        }

        public void DeleteAPost(int id)
        {
            Post postToDelete = GetAPost(id);
            postsRepo.Update(postToDelete);
        }

        public void DownVote(int id)
        {
            Post postToDown = GetAPost(id);
            postToDown.Score--;
            postsRepo.Update(postToDown);
        }

        public List<Post> GetAllPosts()
        {
            return postsRepo.Read();
        }

        public void UpdatePost(Post post, int id)
        {
            Post postToEdit = GetAPost(id);
            postToEdit.Title = post.Title;
            postToEdit.Url = post.Url;
            postsRepo.Update(post);
        }

        public void UpVote(int id)
        {
            Post postToUp = GetAPost(id);
            postToUp.Score++;
            postsRepo.Update(postToUp);
        }

        Post GetAPost(int id)
        {
            Post postToWorkWith = postsRepo.Read().FirstOrDefault(x => x.Id == id);
            return postToWorkWith;
        }

        Post IService.GetAPost(int id)
        {
            throw new NotImplementedException();
        }
    }
}
