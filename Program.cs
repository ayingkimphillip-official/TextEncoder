using System;

namespace TextEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ContinueLoop = true;
            while(ContinueLoop)
            {
                Console.Clear();
                Console.WriteLine("Would you like to proceed to convert a string to it's binary combination?");
                Console.WriteLine("[1] YES");
                Console.WriteLine("[2] NO");
                switch(Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        var Encoder = new Encoder();
                        Console.WriteLine($"Please input a string: ");
                        var InputString = Console.ReadLine();
                        var BinaryStrings = Encoder.ConvertToBinaryStrings(InputString);
                        Console.WriteLine($"The Binary Combination of the Input String is: {BinaryStrings}");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("You have chosen to exit. Thank you for using this Text Encoder. See you again soon!");
                        ContinueLoop = false;
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid option. Please try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
