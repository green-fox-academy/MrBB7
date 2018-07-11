using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Repositories
{
    public interface IGenericRepository<Type>
    {
        void Create(Type post);
        List<Type> Read();
        void Update(Type post);
        void Delete(Type post);
    }
}
