using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        bool charachterNeedsToBeUpperCase = false;
        
        StringBuilder sb = new StringBuilder();

        foreach (char c in identifier) {
            if (char.IsWhiteSpace(c) == true) {
                sb.Append('_');
            } 
            else if (char.IsControl(c) == true) {
                sb.Append("CTRL");
            }
            else if (char.IsPunctuation(c) == true) {
                charachterNeedsToBeUpperCase = true;
            }
            else if (char.IsLetter(c) == false || c >= 'α' && c <= 'ω') {
                sb.Append("");
            }
            else if (charachterNeedsToBeUpperCase == true) {
                sb.Append(char.ToUpper(c));
                charachterNeedsToBeUpperCase = false;
            }
            else {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}
