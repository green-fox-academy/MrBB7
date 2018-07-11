using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditBackend.Models;
using RedditBackend.Services;

namespace RedditBackend.Controllers
{
    public class PostsController : Controller
    {
        IService postsDatabase;

        public PostsController(IService postsDatabase)
        {
            this.postsDatabase = postsDatabase;
        }

        [HttpGet("/posts")]
        public IActionResult List()
        {
            return new JsonResult(postsDatabase.GetAllPosts());
        }

        [HttpPost("/posts")]
        public IActionResult PostAPost(Post post)
        {
            postsDatabase.AddPost(post);
            return RedirectToAction("List");
        }

        [HttpPut("/posts/{id}/upvote")]
        public IActionResult UpVote(int id)
        {
            postsDatabase.UpVote(id);
            return RedirectToAction("List");
        }

        [HttpPut("/posts/{id}/downvote")]
        public IActionResult DownVote(int id)
        {
            postsDatabase.DownVote(id);
            return RedirectToAction("List");
        }

        [HttpDelete("/posts/{id}")]
        public IActionResult Delete(int id)
        {
            postsDatabase.DeleteAPost(id);
            return RedirectToAction("List");
        }

        [HttpPut("/posts/{id}")]
        public IActionResult Put(Post post, int id)
        {
            postsDatabase.UpdatePost(post, id);
            return RedirectToAction("List");
        }
    }
}