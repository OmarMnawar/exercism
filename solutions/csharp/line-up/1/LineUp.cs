public static class LineUp
{
    public static string Format(string name, int number)
    {
        string numberAsString = number.ToString();

        string finalConvertion = string.Empty;
        if (numberAsString.EndsWith("11") || numberAsString.EndsWith("12") || numberAsString.EndsWith("13")) {
            finalConvertion = numberAsString + "th";
        }
        else if (numberAsString.EndsWith("1")) {
            finalConvertion = numberAsString + "st";
        }
        else if (numberAsString.EndsWith("2")) {
            finalConvertion = numberAsString + "nd";
        }
        else if (numberAsString.EndsWith("3")) {
            finalConvertion = numberAsString + "rd";
        }
        else {
            finalConvertion = numberAsString + "th";
        }


        return $"{name}, you are the {finalConvertion} customer we serve today. Thank you!";
    }
}
