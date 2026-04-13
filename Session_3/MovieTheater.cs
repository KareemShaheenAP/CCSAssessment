using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3
{
    internal class MovieTheater
    {
        static void Main(string[] args)
        {
            //Movie Theater
            int[,] seatArray = { { 1, 1, 1, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 } };
            for (int i = 0; i < seatArray.GetLength(0); i++)
            {
                for (int j = 0; j < seatArray.GetLength(1); j++)
                {
                    Console.Write(seatArray[i, j]);
                }
                Console.WriteLine("");
            }
            while (true)
            {
                Console.WriteLine("Please pick a seat as row & column number");
                int rowNum = int.Parse(Console.ReadLine());
                int colNum = int.Parse(Console.ReadLine());
                if (rowNum == 0 || colNum == 0) 
                { 
                    Console.WriteLine("Please enter valid number");
                    continue;
                }
                if (rowNum > seatArray.GetLength(0) || colNum > seatArray.GetLength(1) )
                {
                    Console.WriteLine("Invalid Seat");
                    continue;
                }
                if (seatArray[rowNum - 1, colNum - 1] == 0)
                {
                    Console.WriteLine("Seat already booked");
                    continue;
                }
                seatArray[rowNum - 1, colNum - 1] = 0;
                Console.WriteLine($"Seat booked on row {rowNum} at column {colNum}");

                for (int i = 0; i < seatArray.GetLength(0); i++)
                {
                    for (int j = 0; j < seatArray.GetLength(1); j++)
                    {
                        Console.Write(seatArray[i, j]);
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}
