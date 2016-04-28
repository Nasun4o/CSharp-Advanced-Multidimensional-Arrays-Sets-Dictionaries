using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class Program
    {
        static void Main()
        {
            int[] matrixDimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixDimensions[0], matrixDimensions[1]];

            for (int row = 0; row < matrixDimensions[0]; row++)
            {
                string[] matrixFiller = Console.ReadLine().Split(' ').ToArray();
                for (int col = 0; col < matrixDimensions[1]; col++)
                {
                    matrix[row, col] = int.Parse(matrixFiller[col]);
                }
            }

            int maxSUm = int.MinValue;

            for (int row = 0; row < matrixDimensions[0] -2; row++)
            {
                for (int col = 0; col < matrixDimensions[1] - 2; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                                     + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                                     + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currentSum > maxSUm)
                    {
                        maxSUm = currentSum;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSUm}");
        }
    }
}
