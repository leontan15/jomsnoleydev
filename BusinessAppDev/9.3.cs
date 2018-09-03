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

            //display results
            Console.WriteLine("Sort by Part Discription");


            foreach (var element in nameSorted)
            {
                Console.WriteLine(element);
                
            }
            

            Console.ReadLine();
        }
    }
}
