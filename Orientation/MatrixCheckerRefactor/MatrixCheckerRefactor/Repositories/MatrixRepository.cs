using MatrixCheckerRefactor.Entities;
using MatrixCheckerRefactor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixCheckerRefactor.Repositories
{
    public class MatrixRepository : IGenericRepository<Matrix>
    {
        private MatrixDbContext matrixContext;

        public MatrixRepository(MatrixDbContext matrixContext)
        {
            this.matrixContext = matrixContext;
        }

        public void Add(Matrix element)
        {
            matrixContext.Matrices.Add(element);
            matrixContext.SaveChanges();
        }

        public void Delete(Matrix element)
        {
            matrixContext.Matrices.Remove(element);
            matrixContext.SaveChanges();
        }

        public List<Matrix> Read()
        {
            return matrixContext.Matrices.ToList();
        }

        public void Update(Matrix element)
        {
            matrixContext.Matrices.Update(element);
            matrixContext.SaveChanges();
        }
    }
}
