public static class ResistorColorDuo
{
    enum ColorsSchema {
        Black,
        Brown,
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Violet,
        Grey,
        White
    }
    
    public static int Value(string[] colors)
    {
        int firstNumber = (int)Enum.Parse(typeof(ColorsSchema), colors[0], true);
        int secondNumber = (int)Enum.Parse(typeof(ColorsSchema), colors[1], true);


        return (firstNumber * 10) + secondNumber;
        
    }
}
