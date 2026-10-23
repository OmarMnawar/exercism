using System.Text;

public static class Luhn
{
    public static bool IsValid(string number)
    {
        if (string.IsNullOrWhiteSpace(number) == true) {
            return false;
        }

        char[] chars = number.ToCharArray();
        StringBuilder sb = new();
        

        // Check if array holds letters or spaces, or punctuation first.
        foreach (var c in chars) {
            if (char.IsPunctuation(c) == true || char.IsLetter(c) == true) {
                return false;
            }
            else if (char.IsWhiteSpace(c) == true) {
                continue;
            }
            else {
                sb.Append(c);
            }
        }

        char[] numbers = sb.ToString().ToCharArray();

        if (numbers.Length <= 1) {
            return false;
        }
        
        int sum = 0;
        int index = numbers.Length - 1;
        bool shouldDouble = false;

        while (index >= 0) {
            int digit = numbers[index] - '0';

            if (shouldDouble == true) {
                digit *= 2;
                if (digit > 9) {
                    digit -= 9;
                }
            }

            
            sum += digit;
            shouldDouble = !shouldDouble;
            index--;
        }


        return (sum % 10) == 0;
        
    }
}