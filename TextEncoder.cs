using System;

class Encoder
{
    private const int MAXIMUM_BITS = 5;
    private bool[] TextEncoderValuesHolder = new bool[MAXIMUM_BITS];
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
        ' ',     //27
        '.',     //28
        ',',     //29
        '!',     //30
        '?',     //31
    };

    public Encoder() { }

    public string ConvertToBinaryStrings(string input)
    {
        int[] InputStringToNumberHolder = new int[input.Length];
        string[] InputStringToBinaryHolder = new string[input.Length];
        string InputStringToNumber;
        string InputStringToBinary;

        for (int i = 0; i < input.Length; i++)
        {
            InputStringToNumberHolder[i] = ConvertCharacterToNumber(input[i]);
            InputStringToBinaryHolder[i] = ConvertNumbersToBinaryStrings(InputStringToNumberHolder[i]);
        }
        InputStringToNumber = string.Join(" ", InputStringToNumberHolder);
        InputStringToBinary = string.Join(" ", InputStringToBinaryHolder);
        Console.WriteLine($"Input String to Number(s): {InputStringToNumber}");
        return InputStringToBinary;
    }

    public int ConvertCharacterToNumber(char input)
    {
        int NumberOfCharacter = 0;

        for (int i = 0; i < EncodingTable.Length; i++)
        {
            if (EncodingTable[i] == input)
            {
                NumberOfCharacter = i;
            }
        }
        return NumberOfCharacter;
    }

    public string ConvertNumbersToBinaryStrings(int InputNumber)
    {
        bool[] TextEncoderValues = new bool[MAXIMUM_BITS];
        byte[] BinaryNumbersHolder = new byte[MAXIMUM_BITS];
        string[] BinaryNumbersToStringHolder = new string[MAXIMUM_BITS];
        string BinaryNumbersToString;

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
            BinaryNumbersToStringHolder[i] = BinaryNumbersHolder[i].ToString();
        }
        BinaryNumbersToString = string.Join("", BinaryNumbersToStringHolder);
        return BinaryNumbersToString;
    }
}