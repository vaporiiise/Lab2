using System.ComponentModel.Design;
using System.Net.NetworkInformation;

namespace ConsoleApp65
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Added the Selection Menu for the calculator -Cyr
            Console.WriteLine("Menu driven Calculator");
            Console.WriteLine("***********************");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("***********************");
            Console.WriteLine("type in the desired number to use the calculator's function: ");
            int a = Convert.ToInt32(Console.ReadLine());
            //Added else/if for the function selection -Cyr
            if (a == 1)
            {
                Console.WriteLine("You have chosen Addition.");
                Console.WriteLine("Please enter Number 1: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Number 2: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x + " + " + y + " = " + (x + y));
                 //Added Addition by Liew Jun Wei6
            }
            else if (a == 2) 
            {
                Console.WriteLine("You have chosen Subtraction.");
                Console.WriteLine("Please enter Number 1: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Number 2: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x + " - " + y + " = " + (x - y));
            }
            //Added subtraction by Liew Jun Wei

            //Added Multiplication function for 3. -Cyr
            else if (a == 3)
            {
                Console.WriteLine("You have chosen Multiplication.");
                Console.WriteLine("Please enter Number 1: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Number 2: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x + " x " + y + " = " + (x * y));
            }
            //Added Division function function for 4. -Cyr
            else if (a == 4)
            {
                Console.WriteLine("You have chosen Division.");
                Console.WriteLine("Please enter Number 1: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Number 2: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x + " / " + y + " = " + (x / y));
            }
            //Added a error message if function selection is > 4 -Cyr
            else
                Console.WriteLine("Unknown function! Please run me again.");

        }
    }
}
