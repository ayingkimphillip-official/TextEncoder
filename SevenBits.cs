class SevenBits
{
    private const byte MAXIMUM_BITS = 7;
    private readonly bool[] TextEncoderValues = new bool[MAXIMUM_BITS];

    public SevenBits (byte InputNumber)
    {
        for (int i = MAXIMUM_BITS - 1; i >= 0; i--)
        {
            if (InputNumber % 2 == 1)
            {
                TextEncoderValues[i] = true;
            }
            InputNumber = (byte)(InputNumber / 2);
        }
    }

    public override string ToString()
    {
        string InputString = string.Empty;

        for (int i = 0; i < MAXIMUM_BITS; i++)
        {
            if (TextEncoderValues[i] == true)
            {
                InputString += "1";
            }
            else
            {
                InputString += "0";
            }
        }
        return InputString;
    }
}