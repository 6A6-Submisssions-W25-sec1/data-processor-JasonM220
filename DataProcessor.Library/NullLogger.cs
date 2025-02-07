namespace DataProcessor.Library;

public class NullLogger : ILogger
{
    public async Task LogMessage(string message, string data)
    {
        // does nothing
    }
}
