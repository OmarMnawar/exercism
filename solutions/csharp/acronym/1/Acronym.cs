using System.Text;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        if (string.IsNullOrWhiteSpace(phrase) == true) {
            return string.Empty;
        }

        char[] separators = [' ', '-', '_'];
        string[] words = phrase.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder sb = new();

        foreach (string word in words)
        {
            foreach (char c in word)
            {
                if (char.IsLetter(c))
                {
                    sb.Append(char.ToUpper(c));
                    break;
                }
            }
        }

        return sb.ToString();
    }
}