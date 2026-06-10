static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Split(':')[1].Trim();
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        return logLine.Substring(1, logLine.IndexOf(']') - 1).ToLower();
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        string level = logLine.Substring(1, logLine.IndexOf(']') - 1).ToLower();
        string message = logLine.Split(':')[1].Trim();
        return $"{message} ({level})";
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
