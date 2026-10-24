public static class Proverb
{

    private static string[] inputs =
    {
        "nail",
        "shoe",
        "horse",
        "rider",
        "message",
        "battle",
        "kingdom"
    };

    public static string[] Recite(string[] subjects)
    {
        List<string> recite = [];

        int index = 0;
        int nextIndex = index + 1;

        while (nextIndex < subjects.Length)
        {
            string text1 = string.Join(" ", "For want of a", subjects[index], "the", subjects[nextIndex], "was lost.");

            recite.Add(text1);

            nextIndex++;
            index++;


        }

        if (subjects.Length > 0)
        {
            string text2 = string.Join(" ", "And all for the want of a", subjects[0] +  ".");
            recite.Add(text2);
        }
        
        return [.. recite ];
    }
}