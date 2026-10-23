using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        var sb = new StringBuilder();

        char[] chars = text.ToCharArray();

        foreach (var c in chars) {

            if (char.IsAsciiLetter(c) == false) {
                sb.Append(c);
            } else {
                char baseCharValue = char.IsUpper(c) ? 'A' : 'a';

                int currentIndex = c - baseCharValue;

                int newIndex = (currentIndex + shiftKey) % 26;

                char shiftedChar = (char)(baseCharValue + newIndex);
                
                sb.Append(shiftedChar);
            }
        }

        return sb.ToString();
    }
}