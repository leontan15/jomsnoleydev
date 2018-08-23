using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generate random number
            Random randomNumbers = new Random();
            //array of freq counters 
            int [] sums = new int[13];
            int die1 = 0;
            int die2 = 0;
            int sum = 0;
            //create array for die valyes
            int[,] dieValues = new int[7, 7];
            //roll dice 
            for (int roll = 1; roll <= 36000; ++roll)
            {
                    //Generate random numbers and store in varible
                    die1 = randomNumbers.Next(1, 7);
                    die2 = randomNumbers.Next(1, 7);

                    //Calculate the sum of both die
                    sum = die1 + die2;
                    //add count
                    sums[sum] += 1;
                    //add rolls to array
                    dieValues[die1, die2] += 1;
               
                
            }
            

            //Header title
            Console.WriteLine("       2       3       4       5       6       7       8       9      10      11      12");

            
            //output array
            for (int face = 2; face <= 12; face++ )
            {
            Console.Write("    {0:D4}", sums[face]);

            }
            //spacing for sum die sum output
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //Header 
            Console.WriteLine("          1       2       3       4       5       6 ");
            Console.WriteLine("-------------------------------------------------------------");

            //Loop to store each roll
            for (int roll = 1; roll <=6; roll++)
            {
                //write title on left axis
                Console.Write("   {0:N0} |", roll);
                //write sum of both rolls to table
                for (int c = 1; c <= 6; c++)
                {
                    Console.Write("    {0:D4}", dieValues[roll, c]);
                }

                Console.WriteLine();
            }
            
           Console.ReadLine();
           
        }
    }
}
