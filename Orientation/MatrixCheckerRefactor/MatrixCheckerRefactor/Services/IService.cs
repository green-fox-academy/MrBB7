using MatrixCheckerRefactor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixCheckerRefactor.Services
{
    public interface IService
    {
        string MatrixChecker(string inputMatrix);
        List<Matrix> GetAllMatrices();
    }
}
