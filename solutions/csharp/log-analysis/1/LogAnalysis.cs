public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    
    public static string SubstringAfter(this string str, string seperator) =>
        str.Substring(str.IndexOf(seperator) + seperator.Length);
    
    // TODO: define the 'SubstringBetween()' extension method on the `string` type

    public static string SubstringBetween(this string str, string seperator1, string seperator2)
    {
        int startIndex = str.IndexOf(seperator1) + seperator1.Length;
        int endIndex = str.LastIndexOf(seperator2) - startIndex;
        
        return str.Substring(startIndex, endIndex);
    }

    
    // TODO: define the 'Message()' extension method on the `string` type

    public static string Message(this string str) =>
        SubstringAfter(str, ":").Trim();

    // TODO: define the 'LogLevel()' extension method on the `string` type

    public static string LogLevel(this string str) =>
        SubstringBetween(str, "[", "]");
}