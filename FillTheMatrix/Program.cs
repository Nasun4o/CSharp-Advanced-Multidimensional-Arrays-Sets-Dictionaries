namespace FillTheMatrix
{
    using System;

    public class Program
    {
        public static void Main()
        {
            // int rowColSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Chose betwen patters A and B ");
            char code = (char)Console.Read();
            int[,] matrix = new int[4, 4];
            int currNum = 0;

            if (char.ToLower(code).Equals('a'))
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    for (int col = 0; col < matrix.GetLength(0); col++)
                    {
                        currNum++;
                        matrix[col, row] = currNum;
                        //Console.Write(matrix[col, row]);
                    }
                    //Console.WriteLine();
                }
            }

            else if (char.ToLower(code).Equals('b'))
            {
                currNum = 0;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col % 2 == 0)
                    {
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            currNum++;
                            matrix[row, col] = currNum;
                        }
                    }
                    else
                    {
                        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                        {
                            currNum++;
                            matrix[row, col] = currNum;
                        }
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    Console.Write("{0}", matrix[row, col]);
                }
                Console.WriteLine();
            }

        }

    }
}