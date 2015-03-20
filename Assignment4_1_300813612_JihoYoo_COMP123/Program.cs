﻿/* 
 *  Author's name:Jiho Yoo 
 *  Date : 3/20/2015 
 *  Program description : Array Practice 1 : Dice Rolling App
 *  Revision History : 
 *                    3/16/2015 set up the values
 *                    3/17/2015 calculate roll dice and display in the table
 *                    3/20/2015 find out some errors
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_1_300813612_JihoYoo_COMP123
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sums = new int[13]; 
            int sum = 0;
            int firstDice = 0;  // first Dice
            int secondDice = 0; // second Dice
            int[,] values = new int[7, 7]; // will ignore index 0
            Random rnd = new Random(); //Random key

            //calculate 36000 times roll dice
            for (int index = 0; index < 36000; index ++ )
            {
                firstDice = rnd.Next(1, 7); // 6 numbers
                secondDice = rnd.Next(1, 7); // 6 numbers

                sum = firstDice + secondDice;
                sums[sum] += 1;
                values[firstDice, secondDice] += 1;
            }

            //Display the results
            Console.WriteLine("                          -----Results-----                          ");
            Console.WriteLine("    2     3     4     5     6     7     8     9    10    11    12    ");

            for (int index = 2; index <= 12; index++)
            {
                Console.Write("  {0:0000}", sums[index]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                           -----Chart-----                          ");
            Console.WriteLine("             1        2        3        4        5        6  ");
            Console.WriteLine("     --------------------------------------------------------");
            //Display the results in the chart
            for (int row = 1; row <= 6; row++ ) // set row
            {
                Console.Write("   {0}   |", row);
                for (int col = 1; col <= 6; col++) // set column
                {
                    Console.Write("   {0:0000} |", values[row, col]);
                }
                Console.WriteLine();
                
            }
            Console.WriteLine();
            Console.WriteLine("Enter the any key to exit...");
            Console.ReadKey();
        }
       
    }
}
