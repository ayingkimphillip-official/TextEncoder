using System;

namespace TextEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Please input number to be converted to binary: ");
            int InputNumber = int.Parse(Console.ReadLine());
            var Encoder = new Encoder(InputNumber);

            Console.WriteLine($"Input Number is: {Encoder.EncoderToNumber()}");
            Console.WriteLine($"The Letter for that number is: {Encoder.EncoderToChar()}");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Please input character to be converted to binary: ");
            char InputCharacter = char.Parse(Console.ReadLine());
            var CharacterToNumber = Encoder.ConvertCharacterToNumber(InputCharacter);
            Console.WriteLine($"That character's equivalent to number is: {CharacterToNumber}");
            Console.ReadKey();

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
                        Console.WriteLine($"Please input a string: ");
                        var InputString = Console.ReadLine();
                        var BinaryStrings = Encoder.ConvertToBinaryStrings(InputString);
                        Console.WriteLine($"The Binary Combination of the string is: {BinaryStrings}");
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
