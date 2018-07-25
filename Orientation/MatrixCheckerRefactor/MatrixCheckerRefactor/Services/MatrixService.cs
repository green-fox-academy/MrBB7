using MatrixCheckerRefactor.Models;
using MatrixCheckerRefactor.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixCheckerRefactor.Services
{
    public class MatrixService : IService
    {
        private MatrixRepository matrixRepo;
        private List<List<int>> matrix;

        public MatrixService(MatrixRepository matrixRepo)
        {
            this.matrixRepo = matrixRepo;
            matrix = new List<List<int>>();
        }

        public List<Matrix> GetAllMatrices()
        {
            return matrixRepo.Read();
        }

        public bool IsMatrix(string inputMatrix)
        {
            string[] rows = inputMatrix.Split("\r\n");
            foreach (string row in rows)
            {
                List<int> aRow = new List<int>();
                foreach (var column in row.Split(" "))
                {
                    try
                    {
                        aRow.Add(Int32.Parse(column));
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                matrix.Add(aRow);
            }
            return true;
        }

        public bool IsSquare(List<List<int>> matrixToCheck)
        {
            foreach (var row in matrixToCheck)
            {
                if (row.Count != matrixToCheck.Count)
                    return false;
            }
            return true;
        }

        public bool AreTheColumnsIncreasing(List<List<int>> matrixToCheck)
        {
            for (int i = 0; i < matrixToCheck[0].Count; i++)
            {
                for (int j = 1; j < matrixToCheck.Count; j++)
                {
                    if (matrixToCheck[j][i] < matrixToCheck[j - 1][i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool AreTheRowsIncreasing(List<List<int>> matrixToCheck)
        {
            foreach (var row in matrixToCheck)
            {
                for (int i = 1; i < row.Count; i++)
                {
                    if (row[i] < row[i - 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public string MatrixChecker(string inputMatrix)
        {
            if (inputMatrix == null)
            {
                return "Please give me the numbers";
            }
            else if (IsMatrix(inputMatrix) == false)
            {
                return "The data you provided is unvalid to form a matrix";
            }
            else if (IsSquare(matrix) == false)
            {
                return "This is not a square matrix";
            }
            else if (AreTheColumnsIncreasing(matrix) == false)
            {
                return "The columns of your matrix are not increasing";
            }
            else if (AreTheRowsIncreasing(matrix) == false)
            {
                return "The rows in your matrix are not increasing";
            }

            matrixRepo.Add(new Matrix
            {
                Numbers = inputMatrix,
                Date = DateTime.Now
            });

            return "Your matrix is increasing!";
        }
    }
}
