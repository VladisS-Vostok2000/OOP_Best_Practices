// Rift logging domain
// and logging application
// from the `MonitorAssembly`
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

    // Unneccessary anymore
    public static void Close() {
        // No stupid typechecking anymore
        // so we never need to edit whole
        // assembly (and classes) when extending
        // new functionality, even reassembly is
        // not required now anymore
        if (Logger is not null && Logger is IDisposable toDispose) {
            toDispose.Dispose();
        }
    }
}