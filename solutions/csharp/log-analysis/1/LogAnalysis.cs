public static class LogAnalysis
{
    // After a delimiter
    public static string SubstringAfter(this string message, string delimiter)
    {
        return message.Substring(message.IndexOf(delimiter) + delimiter.Length);
    }

    // Between two delimiters
    public static string SubstringBetween(this string message, string startDelimiter, string endDelimiter)
    {
        int start = message.IndexOf(startDelimiter) + startDelimiter.Length;
        int end = message.IndexOf(endDelimiter);
        return message.Substring(start, end - start);
    }

    // Extract message after ": "
    public static string Message(this string logLine)
    {
        return logLine.SubstringAfter(": ").Trim();
    }

    // Extract log level from "[LEVEL]"
    public static string LogLevel(this string logLine)
    {
        int start = logLine.IndexOf('[') + 1;
        int end = logLine.IndexOf(']');
        return logLine.Substring(start, end - start).ToUpper();
    }
}