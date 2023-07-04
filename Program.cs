using System;
using System.ComponentModel;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int input = 0;
            string series = "";
           
            // Infinite loop to make user enter until valid data is entered
            while (true)
            {
                Console.WriteLine("Enter integer between 1 to 100: "); input = int.Parse(Console.ReadLine());

                if (input >=1 && input <= 100)
                {
                    break;
                }
            }

            while (true)
            {
                // Input series type odd or even
                Console.WriteLine("Specify the series tye: Even or Odd ");

                if (series == "Even" || series == "Odd")
                {
                    break;
                }

            }

            
            if (series == "Odd")
            {
                // Display the output
                Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " +  input + " are:");
                // If series is odd
                // Loop from 1 to max 
                for (int i = 1; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
            // If series is even
            if (series == "Even")
            {
                // Loop from 1 to max 
                for (int i = 1; i <= input; i = i +2)
                {
                    {
                        // Display the output
                        Console.WriteLine(i);
                    }
                }
            }

        }
    }
}
