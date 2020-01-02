using System;

class Encoder
{
    private const int MAXIMUM_BITS = 5;
    private bool[] TextEncoderValuesHolder = new bool[MAXIMUM_BITS];
    // private bool[] TextEncoderValues = new bool[MAXIMUM_BITS];
    private char[] EncodingTable = new char[]
    {
        (char)0, //0
        'a',     //1
        'b',     //2
        'c',     //3
        'd',     //4
        'e',     //5
        'f',     //6
        'g',     //7
        'h',     //8
        'i',     //9
        'j',     //10
        'k',     //11
        'l',     //12
        'm',     //13
        'n',     //14
        'o',     //15
        'p',     //16
        'q',     //17
        'r',     //18
        's',     //19
        't',     //20
        'u',     //21
        'v',     //22
        'w',     //23
        'x',     //24
        'y',     //25
        'z',     //26
        '.',     //27
        '.',     //28
        '.',     //29
        '.',     //30
        '.',     //31
    };

    public Encoder(int InputNumber)
    {
        for (int i = 0; i < TextEncoderValuesHolder.Length; i++)
        {
            if (InputNumber % 2 == 1)
            {
                TextEncoderValuesHolder[i] = true;
            }
            InputNumber = InputNumber / 2;
            Console.WriteLine($"TextEncoderValuesHolder {i}: {TextEncoderValuesHolder[i]}");
        }
    }

    public int EncoderToNumber()
    {
        int InputNumber = 0;
        int power = 0;
        for (int i = 0; i < TextEncoderValuesHolder.Length; i++)
        {
            if (TextEncoderValuesHolder[i] == true)
            {
                InputNumber += (int)Math.Pow(2, power);
            }
            power++;
        }
        return InputNumber;
    }

    public char EncoderToChar()
    {
        return EncodingTable[EncoderToNumber()];
    }

    public int EncoderToInt(char input)
    {
        int InputCharacter = 0;

        for (int i = 0; i < EncodingTable.Length; i++)
        {
            if (EncodingTable[i] == input)
            {
                InputCharacter = i;
                Console.WriteLine($"Encoding Table {i}: {EncodingTable[i]}");
            }
        }

        return InputCharacter;
    }

    public void StringToBinary(string input)
    {
        int[] inputString = new int[input.Length];
        bool[] inputStringToBinary = new bool[input.Length];
        
        for (int i = 0; i < input.Length; i++)
        {
            inputString[i] = EncoderToInt(input[i]);
            Console.WriteLine($"Input String {i} converted to number: {inputString[i]}");
            NumberToBinary(inputString[i]);
        }
    }
    public void NumberToBinary(int InputNumber)
    {
        bool[] TextEncoderValues = new bool[MAXIMUM_BITS];
        byte[] BinaryNumbersHolder = new byte[MAXIMUM_BITS];
        byte[] BinaryNumbers = new byte[MAXIMUM_BITS];
        string variable;

        for (int i = TextEncoderValues.Length - 1; i >= 0; i--)
        {
            if (InputNumber % 2 == 1)
            {
                TextEncoderValues[i] = true;
                BinaryNumbersHolder[i] = 1;
            }
            InputNumber = InputNumber / 2;
        }
        for (int i = 0; i < TextEncoderValues.Length; i++)
        {
            Console.WriteLine($"BinayNumbersHolder {i}: {BinaryNumbersHolder[i]}");
        }
        variable = BinaryNumbersHolder.ToString();
        Console.WriteLine($"String of BinaryNumbersHolder: {variable}");
    }
}