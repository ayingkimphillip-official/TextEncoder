using System;
using System.IO;
using AyingEncodingTable;

namespace FileManagerBoss
{
    class FileManager
    {
        public static bool Manager(string[] filepath, byte[] IndexInEncodingTable)
        {
            bool ContinueInFileLoop = true;
            Console.Clear();
            Console.WriteLine("Please enter Option what you want to do with the data.");
            Console.WriteLine("1.) Save to a File");
            Console.WriteLine("2.) Read a File");
            Console.WriteLine("3.) Copy from one file to another file");
            Console.WriteLine("4.) Exit");

            switch(Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Your file will now be saved. Please enter filename: ");
                    filepath[0] = Console.ReadLine();

                    if (!File.Exists(filepath[0]))
                    {
                        File.WriteAllBytes(filepath[0], IndexInEncodingTable);
                        Console.WriteLine("File saved Successfully");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("File already exists. Please input a different filename.");
                    }

                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Please input a file you want to read.");
                    string FileName = Console.ReadLine();
                    byte[] BytesOfFile = File.ReadAllBytes(FileName);

                    for (int i = 0; i < BytesOfFile.Length; i++)
                    {
                        Console.WriteLine($"{Encoder.EncodingTable[BytesOfFile[(byte)i]]}");
                    }

                    for (int i = 0; i < BytesOfFile.Length; i++)
                    {
                        Console.WriteLine($"{new SevenBits(BytesOfFile[(byte)i])}");
                    }

                    Console.WriteLine("Please press any key to continue.");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Please enter a filepath you want to duplicate.");
                    filepath[0] = Console.ReadLine();
                    if (!File.Exists(filepath[0]))
                    {
                        Console.WriteLine("Please enter a filepath you want to save the duplicated copy.");
                        filepath[1] = Console.ReadLine();
                        CopyFiles(filepath[0], filepath[1]);
                        Console.WriteLine("File has been duplicated successfuly!");
                    }
                    else
                    {
                        Console.WriteLine("Entered file does not exist. Please choose another one.");
                    }

                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("You have chosen to exit.");
                    ContinueInFileLoop = false;
                    Console.ReadKey();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please try again.");
                    Console.ReadKey();
                    break;
            }
            return ContinueInFileLoop;
        }

        public static void CopyFiles(string filename1, string filename2)
        {
            byte[] DuplicateOfFile = File.ReadAllBytes(filename1);
            File.WriteAllBytes(filename2, DuplicateOfFile);
        }
    }
}