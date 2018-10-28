 //***********Question 1**********/

            string[] purchasesArray = File.ReadAllLines(@"purchases.txt");
            //Console.ReadLine();

            //***********Question 2**********/
            // Write contents from array to console
            Console.WriteLine("Read contents from file and display:");
            foreach (string line in purchasesArray)
            {
                Console.WriteLine("\t" + line);

            }
            Console.WriteLine();

            //***********Question 3**********/
            //Write contents from array to Dat file
            File.WriteAllLines(@"PurchaseData.dat", purchasesArray);
            Console.WriteLine("Contents write to DAT file labled PurchaseData.dat:");


            Console.WriteLine("Task complete");
            Console.WriteLine();
            //***********Question 4**********/
            // Read each element into an array called "lines"
            string[] purchasesDat = File.ReadAllLines(@"PurchaseData.dat");

            // Display the file contents by using a foreach loop.
            Console.WriteLine("Display Contents of PurchaseData.dat file: ");
            foreach (string line in purchasesDat)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }


            Console.ReadLine();
