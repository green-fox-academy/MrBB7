using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.RedditService
{
    interface IPostRepository
    {
        Post PlusVote(int Id);
        Post MinusVote(int Id);
    }
}
