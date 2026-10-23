using System.Text;

public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        if (value >= 4000) {
            return "Large Number";
        }

        (string Symbol, int Value)[] romanNumerals = new [] 
        {
            ("M", 1000),
            ("CM", 900), 
            ("D", 500),
            ("CD", 400),
            ("C", 100),
            ("XC", 90),
            ("L", 50),
            ("XL", 40),
            ("X", 10),
            ("IX", 9),
            ("V", 5),
            ("IV", 4),
            ("I", 1)
         };


        // Subtract the value, with the romans numerals values until it either reaches 3 times same symbol or it goes negative
        
        int remainingValue = value;
        
        StringBuilder sb = new StringBuilder();
        foreach (var numeral in romanNumerals)
        {
            // While our number is big enough to subtract this numeral's value...
            while (remainingValue >= numeral.Value)
            {
                sb.Append(numeral.Symbol);
                remainingValue -= numeral.Value; // Subtract it
            }
        }
        
        return sb.ToString();
    }
}