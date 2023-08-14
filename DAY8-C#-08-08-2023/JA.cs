using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProgram
{
    internal class JA
    {
        public void dispId()
        {
          
            int[][] numbers = new int[4][ ];

            numbers[0] = new int[] { 12, 22, 3, 131 };
            numbers[1] = new int[] { 123, 22, 6722 };
            numbers[2] = new int[] { 786, 56,23 };
            numbers[3] = new int[] { 45, 464, 54, 453, 332 };
            Console.WriteLine(numbers[1][2]);
            Console.WriteLine(numbers[3][2]);


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Row({0}): ", i);
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write("{0} ", numbers[i][j]);
                }
                Console.WriteLine();
            }
        }
        public void dispmd()
        {
            int sizee = Convert.ToInt32(Console.Read());
            
            int[][,] jagged_arr1 = new int[4][,]
            {
                new int[,] { { 1, 8 }, { 8, 7 } },
                new int[,] { { 0, 35 }, { 4, 6 }, { 76, 10 } },
                new int[,] { { 7, 57 }, 45, 1 }, { 36, 6 } },
                new int[,] { { 32, 22 }, { 9, 88 }, { 98, 9 } }
            };



            // Jagged array with 4 2-D arrays
            int[][,] numbers = new int[4][,]
            {
                new int[, ] {{32, 3}, {4, 7}},
                new int[, ] {{0, 2}, {242, 6}, {24, 35}},
                new int[, ] {{7, 8}, {3, 35}, {35, 6}},
                new int[, ] {{11, 12}, {2, 21}, {90, 9}}
            };

            for (int i = 0; i < numbers.Length; i++)
            {
                int x = 0;
                for (int j = 0; j < numbers[i].GetLength(x);
                    j++)
                {
                    for (int k = 0; k < numbers[j].Rank; k++)
                    {
                        Console.Write(numbers[i][j, k] + " ");
                    }
                    Console.WriteLine();
                }
                x++;
                Console.WriteLine();
            }
        }
    }
}
