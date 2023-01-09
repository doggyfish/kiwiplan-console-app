using Kiwiplan.Infrastructure.Interfaces;

namespace Kiwiplan.Infrastructure;

public sealed class ConsoleLogger : LoggerBase, ILogger
{
    public override void Log(string logs)
    {
        Console.WriteLine(logs);
    }

}