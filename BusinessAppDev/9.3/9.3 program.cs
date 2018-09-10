using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // initalise array with invoice objects
            var invoices = new[]
            {
                new Invoice(83,"Electric sander",7,57.98M),
                new Invoice(24,"Power Saw",18,99.99M),
                new Invoice(7,"Sledge hammer",11,21.50M),
                new Invoice(77,"Hammer",76,11.99M),
                new Invoice(39,"Lawn mower",3,79.50M),
                new Invoice(68,"Screwdriver",106,6.99M),
                new Invoice(56,"Jig saw",21,11.00M),
                new Invoice(3,"Wrench",34,7.50M),

            };
            // display all
            Console.WriteLine("Original array:");
            foreach (var element in invoices) 
            {
                Console.WriteLine(element);
               
            }
            
            // sort by discription
            var nameSorted =
                from e in invoices
                orderby e.PartDescription
                select e;

            Console.WriteLine();
            //display results
            Console.WriteLine("Sort by Part Description:");
            

            foreach (var element in nameSorted)
            {
                Console.WriteLine(element);
                
            }
            
            // sort by price
            var numberSorted =
                from d in invoices
                orderby d.Price
                select d;

            Console.WriteLine();
            //display results
            Console.WriteLine("Sort by Price:");
            

            foreach (var element in numberSorted)
            {
                Console.WriteLine(element);

            }
            Console.WriteLine();

            // select and sort by description and quanity
            var quantitySorted =
                from d in invoices
                orderby d.Quantity
                select new { d.PartDescription, d.Quantity };

            Console.WriteLine();
            //display results
            Console.WriteLine("Select the PartDescription and Quantity and sort the results by Quantity:");


            foreach (var element in quantitySorted)
            {
                Console.WriteLine(element);

            }
            Console.WriteLine();

            // sort by price
            var priceSelected =
                from d in invoices
                let invoiceTotal = d.Quantity * d.Price
                orderby invoiceTotal descending
                select new { d.PartDescription, invoiceTotal };

            Console.WriteLine();
            //display results
            Console.WriteLine("Calculated the invoices value and sort it by the total, only selected the Part Description and Invoice Total:");


            foreach (var element in priceSelected)
            {
                Console.WriteLine(element);

            }
            Console.WriteLine();



            // Invoice total
            var totalInvoice =
                from f in priceSelected
                where f.invoiceTotal >= 200M && f.invoiceTotal <= 500M
                select new { f.PartDescription, f.invoiceTotal };

            Console.WriteLine();
            //display results
            Console.WriteLine("Select Invoice Range:");


            foreach (var element in totalInvoice)
            {
                Console.WriteLine(element);

            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
