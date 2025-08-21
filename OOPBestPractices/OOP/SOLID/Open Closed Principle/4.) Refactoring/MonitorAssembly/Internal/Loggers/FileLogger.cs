namespace OOPBestPractices.OOP.SOLID.OpenClosedPrinciple.MonitorAssembly.Internal;

// Adding new logger
internal static class FileLogger {
    private static StreamWriter Writer { get; set; }



    static FileLogger() {
        Writer = new("log.txt");
    }



    public static void Log(string log) {
        Writer.WriteLine(log);
    }

    public static void Close() {
        Writer.Dispose();
    }
}
