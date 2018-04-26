using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number_4
{
    class Program
    {
        private static object data;

        static void Main(string[] args)
        {
            //Application prompts the user to enter an integer.
            Console.WriteLine("Welcome! Learn Your Squares and Qubes!");
            int square = 1;
            while (true)
            {
                Console.WriteLine("Enter an Integer");
                String input = Console.ReadLine();

                int x;
                x = int.Parse(input);
                Console.WriteLine("Number\tSquared\tCubed");
                Console.WriteLine("=======\t=======\t=======");
                for (int i = 1; i <= x; i++)
                {

                    Console.Write(i + "\t");
                    Console.Write(i * i + "\t");
                    Console.WriteLine(i * i * i);
                }
                Console.Write("Would you like to continue? (Y/N)?");
                //reassigning input
                input = Console.ReadLine();
               
                if (input == "Y")
                    continue;

                else if (input == "N")
                    Console.WriteLine("Thanks!.");
                Console.ReadKey();
                return;


                
            }
        }
    }
}
