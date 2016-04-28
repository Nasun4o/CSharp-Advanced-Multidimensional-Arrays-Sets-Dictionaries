using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            string[,] matrix = new string[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = Console.ReadLine();

                }

            }

            string[] command = Console.ReadLine().Split(' ').ToArray();

            while (command[0] != "END")
            {
                string temp = string.Empty;
                int x1 = int.Parse(command[1]);
                int y1 = int.Parse(command[2]);
                int x2 = int.Parse(command[3]);
                int y2 = int.Parse(command[4]);

                if (x1 < matrix.GetLength(0) && y1 < matrix.GetLength(1) && x2 < matrix.GetLength(0) && y2 < matrix.GetLength(1))
                {
                    temp = matrix[x1, y1];
                    matrix[x1, y1] = matrix[x2, y2];
                    matrix[x2, y2] = temp;
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write($"{matrix[i, j]}");

                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
                command = Console.ReadLine().Split( ' ').ToArray();
            }
        }
    }
}
