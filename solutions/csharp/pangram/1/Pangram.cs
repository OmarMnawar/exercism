public static class Pangram
{
    public static bool IsPangram(string input)
    {

        if (string.IsNullOrWhiteSpace(input) == true) {
            return false;
        }
        
        char[] chars = input.ToLower().Trim().ToCharArray();

        char[] occuredAlphabetsLetters = new char[26];

        int index = 0;

        foreach (var c in chars) {
            if (char.IsWhiteSpace(c) == true || char.IsPunctuation(c) == true) {
                continue;
            }
            
            if (char.IsAsciiLetter(c) == true) {

                if (Array.Exists(occuredAlphabetsLetters, l => l == c)) {
                    continue;
                } else {
                    if (index < 26) {
                        occuredAlphabetsLetters[index] = c;
                        index++;
                    }
                }
            }
        }

        return index == 26;
    }
}
