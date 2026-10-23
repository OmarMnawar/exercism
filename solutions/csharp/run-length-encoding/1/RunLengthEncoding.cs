using System.Text;

public static class RunLengthEncoding
{   
    public static string Encode(string input)
    {
        if (string.IsNullOrWhiteSpace(input) == true) {
            return string.Empty;
        }
        
        char[] chars = input.ToCharArray();

        foreach (var c in chars) {
            if (char.IsDigit(c) == true) {
                return string.Empty;
            }
        }

        StringBuilder sb = new();
        int count = 1;
        
        for (int i = 0; i < chars.Length; i++)
        {
            if (i + 1 < chars.Length && chars[i] == chars[i + 1])
            {
                count++;
            }
            else
            {
                if (count > 1)
                {
                    sb.Append(count);
                }
                sb.Append(chars[i]);
            
                count = 1; 
            }
        }

        return sb.ToString();
    }

                                

    public static string Decode(string input)
    {    
        if (string.IsNullOrWhiteSpace(input) == true) {
            return string.Empty;
        }
        
        char[] chars = input.ToCharArray();
        StringBuilder sb = new();
        int i = 0;
        
        while (i < chars.Length)
        {
            int count = 0;
            while (i < chars.Length && char.IsDigit(chars[i]))
            {
                count = (count * 10) + (chars[i] - '0');
                i++;
            }

            if (count == 0)
            {
                count = 1;
            }

            char letter = chars[i];

            for (int j = 0; j < count; j++)
            {
                sb.Append(letter);
            }

            i++;
        }
        
        return sb.ToString();
    }
}
