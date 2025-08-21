namespace OOPBestPractices.OOP.SOLID.OpenClosedPrinciple.MonitorAssembly;

// Implementing new logger as usual
// Crap, now logger must be public
// for domain logic injection
// even if its not being use
// So we replace `MonitorLogger`
// from `Internal` to `Loggers`
public class MonitorLogger {
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
}
