using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reddit.Models;

namespace Reddit.Repositories
{
    public interface IRepository
    {
        void Post(Post reddit);
        List<Reddit> GetAllReddits();
        void EditReddit(Reddit editedReddit);
        Reddit GetReddit(int id);
        void Delete(int id);
        List<Reddit> Filter(string filterWord);
    }
}
