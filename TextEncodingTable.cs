namespace AyingEncodingTable
{
    class Encoder
    {
        public static readonly char[] EncodingTable = new char[]
        {
            ' ',     //0
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
            ',',     //28
            '!',     //29
            '?',     //30
            'A',     //31
            'B',     //32
            'C',     //33
            'D',     //34
            'E',     //35
            'F',     //36
            'G',     //37
            'H',     //38
            'I',     //39
            'J',     //40
            'K',     //41
            'L',     //42
            'M',     //43
            'N',     //44
            'O',     //45
            'P',     //46
            'Q',     //47
            'R',     //48
            'S',     //49
            'T',     //50
            'U',     //51
            'V',     //52
            'W',     //53
            'X',     //54
            'Y',     //55
            'Z',     //56
            '1',     //57
            '2',     //58
            '3',     //59
            '4',     //60
            '5',     //61
            '6',     //62
            '7',     //63
            '8',     //64
            '9',     //65
            '0',     //66
            '@',     //67
            '#',     //68
            '$',     //69
            '%',     //70
            '^',     //71
            '&',     //72
            '*',     //73
            '(',     //74
            ')',     //75
            '/',     //76
            '\\',    //77
            '|',     //78
            '[',     //79
            ']',     //80
            '{',     //81
            '}',     //82
            ':',     //83
            ';',     //84
            '"',     //85
            '\'',    //86
            '<',     //89
            '>',     //90
            '-',     //91
            '_',     //92
            '+',     //93
            '=',     //94
        };
        
        public static byte[] CharacterToNumber(string InputString)
        {
            byte[] CharacterIndexInEncodingTable = new byte[InputString.Length];

            for (int i = 0; i < CharacterIndexInEncodingTable.Length; i++)
            {
                CharacterIndexInEncodingTable[i] = 95;
                for (int j = 0; j < EncodingTable.Length; j++)
                {
                    if (InputString[i] == EncodingTable[j])
                    {
                        CharacterIndexInEncodingTable[i] = (byte)j;
                    }
                }
            }
            return CharacterIndexInEncodingTable;
        }

        public static SevenBits[] ToBinaryStrings(string InputString)
        {
            byte[] NumberOfCharacter = CharacterToNumber(InputString);
            SevenBits[] BinaryString = new SevenBits[NumberOfCharacter.Length];

            for (int i = 0; i < BinaryString.Length; i++)
            {
                BinaryString[i] = new SevenBits(NumberOfCharacter[i]);
            }

            return BinaryString;
        }
    }
}