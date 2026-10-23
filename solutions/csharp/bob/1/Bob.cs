public static class Bob
{
    public static string Response(this string statement)
    {
        string response = string.Empty;
        statement = statement.Trim();
        
        if (string.IsNullOrWhiteSpace(statement))
        {
            response = "Fine. Be that way!";
        }
        else if (statement.EndsWith('?'))
        {
            if (statement.Any(char.IsLetter) && string.Equals(statement, statement.ToUpper()))
            {
                response = "Calm down, I know what I'm doing!";
            }
            else
            {
                response = "Sure.";
            }
        }
        else if (statement.Any(char.IsLetter) && string.Equals(statement, statement.ToUpper()))
        {
            response = "Whoa, chill out!";
        }
        else
        {
            response = "Whatever.";
        }        
        return response;
    }
}