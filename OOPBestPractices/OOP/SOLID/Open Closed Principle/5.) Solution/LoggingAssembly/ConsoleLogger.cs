namespace OOPBestPractices.OOP.SOLID.OpenClosedPrinciple.LoggingAssembly;
public sealed class ConsoleLogger : ILogger {
    private static ConsoleLogger? This { get; set; }



    private ConsoleLogger() {
        This = new();
    }



    public static ConsoleLogger GetInstance() {
        This ??= new();

        return This;
    }



    public void Log(string log) {
        Console.WriteLine(log);
    }
}
