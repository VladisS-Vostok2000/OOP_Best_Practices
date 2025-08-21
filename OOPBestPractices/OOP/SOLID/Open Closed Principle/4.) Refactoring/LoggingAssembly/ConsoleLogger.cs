namespace OOPBestPractices.OOP.SOLID.OpenClosedPrinciple.LoggingAssembly;

// Removing `static` trash
public sealed class ConsoleLogger : ILogger {
    private static ConsoleLogger? This { get; set; }



    private ConsoleLogger() {
        This = new();
    }


    // To work with static methods
    // implementing singleton pattern
    public static ConsoleLogger GetInstance() {
        This ??= new();

        return This;
    }



    public void Log(string log) {
        Console.WriteLine(log);
    }
}
