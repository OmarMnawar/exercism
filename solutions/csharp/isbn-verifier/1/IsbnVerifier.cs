public static class IsbnVerifier
{
    public static bool IsValid(string number)
    {
        if (string.IsNullOrWhiteSpace(number)) 
        {
            return false;
        }
        
        char[] chars = number.ToCharArray();

        int[] foundNumbers = new int[10];

        int i = 0;

        foreach (var c in chars) {
            if (char.IsPunctuation(c) == true || char.IsWhiteSpace(c) == true) {
                continue;
            }

            if (i >= 10) {
                return false;
            }
            
            if (c == 'x' || c == 'X') {

                if (i != 9) {
                    return false;
                }
                
                foundNumbers[i] = 10;
            }
            else if (char.IsLetter(c) == true)
            {
                return false;
            }
            else {
                foundNumbers[i] = (c - '0');
            }
            
            i++;
        }

        if (i != 10) {
            return false; 
        }
        
        i = 0;

        int sum = foundNumbers[0] * 10 + foundNumbers[1] * 9 + foundNumbers[2] * 8 + foundNumbers[3] * 7 + foundNumbers[4] * 6 + 
                foundNumbers[5] * 5 + foundNumbers[6] * 4 + foundNumbers[7] * 3 + foundNumbers[8] * 2 + foundNumbers[9] * 1;
        
        return sum % 11 == 0;         
    }
}