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
            var CharacterToNumber = Encoder.EncoderToInt(InputCharacter);
            Console.WriteLine($"That character's equivalent to number is: {CharacterToNumber}");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine($"Please input a string: ");
            var InputString = Console.ReadLine();
            Encoder.StringToBinary(InputString); //var StringToBinary = make a variabl name StringToBinary


            Console.ReadKey();
        }
    }
}
