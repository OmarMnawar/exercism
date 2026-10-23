public static class ReverseString
{
    public static string Reverse(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) {
            return string.Empty;
        }
        
        var charArray = input.ToCharArray(0, input.Length);

        string reversed = string.Empty;

        for (int i = charArray.Length - 1; i >= 0; i--) {
            reversed += charArray[i];
        }

        return reversed;
    }
}