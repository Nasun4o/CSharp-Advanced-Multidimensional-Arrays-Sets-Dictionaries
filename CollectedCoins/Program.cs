namespace CollectedCoins
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            char[][] board = new char[4][];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = Console.ReadLine().ToCharArray();
            }

            char[] commands = Console.ReadLine().ToCharArray();

            int coins = 0;
            int wallHits = 0;
            int leftRight = 0;
            int upDown = 0;

            foreach (char move in commands)
            {
                int x = 0;
                int y = 0;

                switch (move)
                {
                    case '>': x++; break;
                    case '<': x--; break;
                    case 'V': y++; break;
                    case '^': y--; break;
                }

                x += leftRight;
                y += upDown;

                if (y > 3 || y < 0)
                {
                    wallHits++;
                    y = upDown;
                }
                else if (x >= board[y].Length)
                {
                    wallHits++;
                    y = upDown;
                }

                if (x >= board[y].Length || x < 0)
                {
                    wallHits++;
                    x = leftRight;
                }

                if (board[y][x] == '$')
                {
                    coins++;
                }

                leftRight = x;
                upDown = y;
            }

            Console.WriteLine($"Coins collected: {coins}\nWalls hit: {wallHits}");
        }
    }
}

