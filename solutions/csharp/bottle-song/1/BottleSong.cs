using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

public static class BottleSong
{

    private static (string NumberAsWord, int Number)[] NumbersAsWords =
    {
        ("Ten", 10),
        ("Nine", 9),
        ("Eight", 8),
        ("Seven", 7),
        ("Six", 6),
        ("Five", 5),
        ("Four", 4),
        ("Three", 3),
        ("Two", 2),
        ("One", 1),
        ("No", 0),
    };

    private static int currentBottlesCount = 0;


    public static IEnumerable<string> Recite(int startBottles, int takeDown)
    {

        var list = new List<string>();
        currentBottlesCount = startBottles;

        if (currentBottlesCount > 10 || currentBottlesCount < 0 || takeDown > 10 || takeDown < 0)
        {
            return list;
        }

        const int repeat = 2;
        

        for (int v = 0; v < takeDown; v++)
        {
            for (int i = 0; i < repeat; i++)
            {
                for (int j = 0; j < NumbersAsWords.Length; j++)
                {
                    if (NumbersAsWords[j].Number == currentBottlesCount)
                    {
                        string bottle = currentBottlesCount == 1 ? "bottle" : "bottles";

                        list.Add(string.Join(" ", NumbersAsWords[j].NumberAsWord, "green", bottle, "hanging on the wall,"));
                        break;
                    }
                }
            }
            
            list.Add("And if one green bottle should accidentally fall,");

            for (int j = 0; j < NumbersAsWords.Length; j++)
            {
                int subtraction = currentBottlesCount - 1;

                if (NumbersAsWords[j].Number == subtraction)
                {
                    string bottle = subtraction == 1 ? "bottle" : "bottles";

                    list.Add(string.Join(" ", "There'll be", NumbersAsWords[j].NumberAsWord.ToLower(), "green", bottle, "hanging on the wall."));
                    break;
                }
            }

            if (v < takeDown - 1)
            {
                list.Add(string.Empty);
            }

            currentBottlesCount--;
        }

        return list;
    }
}
