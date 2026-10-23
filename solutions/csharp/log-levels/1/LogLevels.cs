using System;
static class LogLine
{
    public static string Message(string logLine)
    {
        var strArray = logLine.Split(':');
         return strArray[1].Trim();
    }
    
    public static string LogLevel(string logLine)
    {
        string[] strArray = logLine.Split(':');
        return strArray[0].ToLower().Replace("[", "").Replace("]", "");
    }
    public static string Reformat(string logLine)
    {
        var strArray = logLine.Split(':');

        string reforamtedStr = string.Concat(strArray[1].Trim(), strArray[0].ToLower().Replace("[", " (")
                                            .Replace("]", ")"));        
        return reforamtedStr;
            
    }
}
