using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            // Invocation of random math class
            var rnd = new Random();

            // Array of frequency counters
            var dieRollOne = new int[7];
            var dieRollTwo = new int[7];

            // Roll die 36,000 times 
            for (int roll = 1; roll <= 36000; ++roll)
            {
                // Adding a random number to die roll one
                dieRollOne[1] = rnd.Next(1, 7);
                dieRollOne[2] = rnd.Next(1, 7);
                dieRollOne[3] = rnd.Next(1, 7);
                dieRollOne[4] = rnd.Next(1, 7);
                dieRollOne[5] = rnd.Next(1, 7);
                dieRollOne[6] = rnd.Next(1, 7);
                // Adding a random number to die roll two
                dieRollTwo[1] = rnd.Next(1, 7);
                dieRollTwo[2] = rnd.Next(1, 7);
                dieRollTwo[3] = rnd.Next(1, 7);
                dieRollTwo[4] = rnd.Next(1, 7);
                dieRollTwo[5] = rnd.Next(1, 7);
                dieRollTwo[6] = rnd.Next(1, 7);
            }

            // Declaration of new arrays
            var outputOne = new int[7];
            var outputTwo = new int[7];
            var outputThree = new int[7];
            var outputFour = new int[7];
            var outputFive = new int[7];
            var outputSix = new int[7];

            // Add the arrays together
            outputOne[1] = dieRollOne[1] + dieRollTwo[1];
            outputOne[2] = dieRollOne[1] + dieRollTwo[2];
            outputOne[3] = dieRollOne[1] + dieRollTwo[3];
            outputOne[4] = dieRollOne[1] + dieRollTwo[4];
            outputOne[5] = dieRollOne[1] + dieRollTwo[5];
            outputOne[6] = dieRollOne[1] + dieRollTwo[6];

            outputTwo[1] = dieRollOne[2] + dieRollTwo[1];
            outputTwo[2] = dieRollOne[2] + dieRollTwo[2];
            outputTwo[3] = dieRollOne[2] + dieRollTwo[3];
            outputTwo[4] = dieRollOne[2] + dieRollTwo[4];
            outputTwo[5] = dieRollOne[2] + dieRollTwo[5];
            outputTwo[6] = dieRollOne[2] + dieRollTwo[6];

            outputThree[1] = dieRollOne[3] + dieRollTwo[1];
            outputThree[2] = dieRollOne[3] + dieRollTwo[2];
            outputThree[3] = dieRollOne[3] + dieRollTwo[3];
            outputThree[4] = dieRollOne[3] + dieRollTwo[4];
            outputThree[5] = dieRollOne[3] + dieRollTwo[5];
            outputThree[6] = dieRollOne[3] + dieRollTwo[6];

            outputFour[1] = dieRollOne[4] + dieRollTwo[1];
            outputFour[2] = dieRollOne[4] + dieRollTwo[2];
            outputFour[3] = dieRollOne[4] + dieRollTwo[3];
            outputFour[4] = dieRollOne[4] + dieRollTwo[4];
            outputFour[5] = dieRollOne[4] + dieRollTwo[5];
            outputFour[6] = dieRollOne[4] + dieRollTwo[6];

            outputFive[1] = dieRollOne[5] + dieRollTwo[1];
            outputFive[2] = dieRollOne[5] + dieRollTwo[2];
            outputFive[3] = dieRollOne[5] + dieRollTwo[3];
            outputFive[4] = dieRollOne[5] + dieRollTwo[4];
            outputFive[5] = dieRollOne[5] + dieRollTwo[5];
            outputFive[6] = dieRollOne[5] + dieRollTwo[6];

            outputSix[1] = dieRollOne[6] + dieRollTwo[1];
            outputSix[2] = dieRollOne[6] + dieRollTwo[2];
            outputSix[3] = dieRollOne[6] + dieRollTwo[3];
            outputSix[4] = dieRollOne[6] + dieRollTwo[4];
            outputSix[5] = dieRollOne[6] + dieRollTwo[5];
            outputSix[6] = dieRollOne[6] + dieRollTwo[6];

            // Numbers above 
            Console.WriteLine("  1 2 3 4 5 6");

            // Output to the matrix
            Console.Write("1 ");

            for (var face = 1; face < outputOne.Length; ++face)
            { 
                Console.Write(outputOne[face] + " ");

            }

            // Add line space
            Console.WriteLine("");

            Console.Write("2 ");

            for (var face = 1; face < outputTwo.Length; ++face)
            {
                Console.Write(outputTwo[face] + " ");

            }

            // Add line space
            Console.WriteLine("");

            Console.Write("3 ");

            for (var face = 1; face < outputThree.Length; ++face)
            {
                Console.Write(outputThree[face] + " ");

            }

            // Add line space
            Console.WriteLine("");

            Console.Write("4 ");

            for (var face = 1; face < outputFour.Length; ++face)
            {
                Console.Write(outputFour[face] + " ");

            }

            // Add line space
            Console.WriteLine("");

            Console.Write("5 ");

            for (var face = 1; face < outputFive.Length; ++face)
            {
                Console.Write(outputFive[face] + " ");

            }

            // Add line space
            Console.WriteLine("");

            Console.Write("6 ");

            for (var face = 1; face < outputSix.Length; ++face)
            {
                Console.Write(outputSix[face] + " ");

            }

            Console.ReadLine();

        }
    }
}
