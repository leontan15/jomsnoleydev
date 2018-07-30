//Decalre varibles
            int num1;
            int num2;
            int num3;
            int num4;
            int num5;
            int negative = 0;
            int positive = 0;
            int zero = 0;
            

            //prompt user and read first 
            Console.Write("Please input number 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            //prompt user and read first 
            Console.Write("Please input number 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            //prompt user and read first 
            Console.Write("Please input number 3: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            //prompt user and read first 
            Console.Write("Please input number 4: ");
            num4 = Convert.ToInt32(Console.ReadLine());
            //prompt user and read first 
            Console.Write("Please input number 5: ");
            num5 = Convert.ToInt32(Console.ReadLine());

            //Display number
            // Determine Count
            if (num1 > 0)
            {
                positive++;
            }
            if (num1 < 0)
            {
                negative++;
            }
            if (num1 == 0)
            {
                zero++;
            }
            //num2
            if (num2 > 0)
            {
                positive++;
            }
            if (num2 < 0)
            {
                negative++;
            }
            if (num2 == 0)
            {
                zero++;
            }
            //num3
            if (num3 > 0)
            {
                positive++;
            }
            if (num3 < 0)
            {
                negative++;
            }
            if (num3 == 0)
            {
                zero++;
            }
            //num4
            if (num4 > 0)
            {
                positive++;
            }
            if (num4 < 0)
            {
                negative++;
            }
            if (num4 == 0)
            {
                zero++;
            }

            //num5
            if (num5 > 0)
            {
                positive++;
            }
            if (num5 < 0)
            {
                negative++;
            }
            if (num5 == 0)
            {
                zero++;
            }

            //Display counts
            Console.WriteLine("Count for positive intergers" +" "+ positive);
            Console.WriteLine("Count for negative intergers" +" "+ negative);
            Console.WriteLine("Count for zero intergers" +" " + zero);
            Console.ReadLine();
