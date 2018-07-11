using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Repositories
{
    public interface ICRUDRepository<Type>
    {
        Type Create(Type post);
        List<Type> Read();
        Type Update(int id);
        Type Delete(int id);
    }
}
