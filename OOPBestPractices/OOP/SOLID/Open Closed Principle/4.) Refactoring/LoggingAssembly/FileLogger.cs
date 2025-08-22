namespace OOPBestPractices.OOP.SOLID.OpenClosedPrinciple.LoggingAssembly;

// Removing `static` trash
// Implementing another
// common function
// as `IDisposable`
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
