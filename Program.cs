using System;
using System.Linq;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] matrix = new string[sizeOfMatrix[0], sizeOfMatrix[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)  // fill the Matrix
            {
                string[] lineStrs = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = lineStrs[col];
                }
            }

            int count = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1 ; row++) //restrinction not go out of row
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col+1] &&
                        matrix[row+1, col] == matrix[row+1, col+1] &&
                        matrix[row, col] == matrix[row+1, col+1])

                    {
                        count++; //we found square matrix will all elements equal = the same value
                    }
                }
            }

            if (count > 0)
            {
                Console.WriteLine(count);
            }
            else if ( count == 0)
            {
                Console.WriteLine(0);
            }
        }
    }
}
