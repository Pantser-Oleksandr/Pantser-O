using System;

public class DecimalString : StringBase
{
    public DecimalString() : base() { }

    public DecimalString(string str) : base(ValidateDecimalString(str) ? str : "") { }

    public DecimalString(int number) : base(number.ToString()) { }

    private static bool ValidateDecimalString(string str)
    {
        if (string.IsNullOrEmpty(str))
            return false;

        int startIndex = 0;
        if (str[0] == '+' || str[0] == '-')
            startIndex = 1;

        for (int i = startIndex; i < str.Length; i++)
        {
            if (!char.IsDigit(str[i]))
                return false;
        }

        return true;
    }

    public int GetNumericValue()
    {
        if (string.IsNullOrEmpty(base.GetString()))
            return 0;

        return int.Parse(base.GetString());
    }

    public static int Difference(DecimalString a, DecimalString b)
    {
        return a.GetNumericValue() - b.GetNumericValue();
    }

    public static bool IsGreater(DecimalString a, DecimalString b)
    {
        return a.GetNumericValue() > b.GetNumericValue();
    }

    public static bool IsLess(DecimalString a, DecimalString b)
    {
        return a.GetNumericValue() < b.GetNumericValue();
    }
}