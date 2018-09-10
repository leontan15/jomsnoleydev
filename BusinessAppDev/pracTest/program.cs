using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTestAppPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            var friends = new[]
                {
                new Friend ("Mackay","James",17,5,1997,0412433828),


            };
            // display all
            Console.WriteLine("Friend List:");

            foreach (var element in friends)
            {
                Console.WriteLine(element);

            }
            Console.ReadLine();

        }
    }
}
    

