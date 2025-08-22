namespace OOPBestPractices.OOP.SOLID.OpenClosedPrinciple.LoggingAssembly;

// Implementing logger
// as usual
// No more thouthents 
// of changes
// and recompilations
// Expansion? Easy peasy
// Its full enough now
public sealed class MonitorLogger : ILogger, IDisposable {
    private string IP { get; init; }



    public MonitorLogger(string ip) {
        IP = ip;
    }



    public void Log(string log) {
        // Some log domain logic here
    }

    public void Close() {
        // Some log domain logic here
    }

    public void Dispose() {
        // Some application logic here
    }
}