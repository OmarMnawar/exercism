public static class ScrabbleScore
{
    private static (char Letter, int Value)[] lettersWithValues = {
        ('A', 1),
        ('E', 1),
        ('I', 1),
        ('O', 1),
        ('U', 1),
        ('L', 1),
        ('N', 1),
        ('R', 1),
        ('S', 1),
        ('T', 1),
        ('D', 2),
        ('G', 2),
        ('B', 3),
        ('C', 3),
        ('M', 3),
        ('P', 3),
        ('F', 4),
        ('H', 4),
        ('V', 4),
        ('W', 4),
        ('Y', 4),
        ('K', 5),
        ('J', 8),
        ('X', 8),
        ('Q', 10),
        ('Z', 10),
    };
    
    public static int Score(string input)
    {
        if (string.IsNullOrWhiteSpace(input) == true) {
            return 0;
        }
        
        char[] chars = input.ToUpper().ToCharArray();

        int score = 0;

        foreach (var c in chars) {
            
            if (char.IsAsciiLetter(c) == false) {
                continue;
            }

            for (int i = 0; i < lettersWithValues.Length; i++) {
                if (c.Equals(lettersWithValues[i].Letter) == true) {
                    score += lettersWithValues[i].Value;
                }
            }
            
        }

        return score;
    }
}