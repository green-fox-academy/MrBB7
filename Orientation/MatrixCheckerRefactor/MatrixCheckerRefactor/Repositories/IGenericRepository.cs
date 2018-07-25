using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixCheckerRefactor.Repositories
{
    public interface IGenericRepository<Type>
    {
        List<Type> Read();
        void Add(Type element);
        void Delete(Type element);
        void Update(Type element);
    }
}
