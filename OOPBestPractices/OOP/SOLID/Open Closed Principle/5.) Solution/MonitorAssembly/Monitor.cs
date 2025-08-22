namespace OOPBestPractices.OOP.SOLID.OpenClosedPrinciple.MonitorAssembly;
public static class Monitor {
    // Implementing injection
    public static ILogger? Logger { get; set; }



    public static void Log(string log) {
        // Simulating logging
        // as common domain logic
        try {
            Logger?.Log(log);
        }
        catch (Exception ex) {
            throw new Exception("Logging error", ex);
        }
    }

    public static void Close() {
        if (Logger is not null && Logger is IDisposable toDispose) {
            toDispose.Dispose();
        }
    }
}