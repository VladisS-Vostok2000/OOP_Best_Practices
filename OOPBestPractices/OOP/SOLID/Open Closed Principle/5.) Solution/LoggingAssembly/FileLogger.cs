namespace OOPBestPractices.OOP.SOLID.OpenClosedPrinciple.LoggingAssembly;
public sealed class FileLogger : ILogger, IDisposable {
    private StreamWriter Writer { get; set; }



    FileLogger(string path) {
        Writer = new(path);
    }



    public void Log(string log) {
        Writer.WriteLine(log);
    }

    public void Dispose() {
        Writer.Dispose();
    }
}
