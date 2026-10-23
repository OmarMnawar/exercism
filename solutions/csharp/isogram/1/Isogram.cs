using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        if (string.IsNullOrWhiteSpace(word) == true) {
            return true;
        }

        HashSet<char> seenChars = new HashSet<char>();

        foreach (var c in word.ToLower())
        {
            if (char.IsLetter(c) == true)
            {
                if (seenChars.Contains(c) == true) {
                    return false;
                } else {
                    seenChars.Add(c);
                }
            }
        }
        return true;
    }
}
