using System;
using AyingEncodingTable;
using FileManagerBoss;

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
                        Console.WriteLine($"Please input a string: ");
                        var InputString = Console.ReadLine();

                        Console.WriteLine($"Aying Encoding Table for: {InputString}");
                        byte[] IndexInEncodingTable = Encoder.CharacterToNumber(InputString);
                        string IndexInEncodingTableStrings;
                        for (int i = 0; i < IndexInEncodingTable.Length; i++)
                        {
                            Console.WriteLine($"'{InputString[i]}': {IndexInEncodingTable[i]} ");
                        }
                        IndexInEncodingTableStrings = string.Join(" ", IndexInEncodingTable);
                        Console.WriteLine($"Aying Encoding Table of: [{InputString}]");
                        Console.WriteLine($"{IndexInEncodingTableStrings}\n");


                        Console.WriteLine($"The Binary Combination for: {InputString}");
                        SevenBits[] BinaryStrings = Encoder.ToBinaryStrings(InputString);
                        string[] StringForBinaryStringsHolder = new string[BinaryStrings.Length];
                        string StringForBinaryStrings;
                        for (int i = 0; i < BinaryStrings.Length; i++)
                        {
                            Console.WriteLine($"'{InputString[i]}' - '{IndexInEncodingTable[i]}' : {BinaryStrings[i]} ");
                            StringForBinaryStringsHolder[i] = BinaryStrings[i].ToString();
                        }
                        StringForBinaryStrings = string.Join(" ", StringForBinaryStringsHolder);
                        Console.WriteLine($"Binary Combination of: [{InputString}]");
                        Console.WriteLine($"{StringForBinaryStrings}");

                        Console.ReadKey();
                        string[] filenames = new string[2];
                        bool ContinueInFileLoop = true;
                        while (ContinueInFileLoop)
                        {
                            ContinueInFileLoop = FileManager.Manager(filenames, IndexInEncodingTable);
                        }

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
