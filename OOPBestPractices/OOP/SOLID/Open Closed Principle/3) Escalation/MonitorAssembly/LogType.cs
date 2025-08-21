namespace OOPBestPractices.OOP.SOLID.OpenClosedPrinciple.MonitorAssembly;
public enum LogType {
    None,
    Console,
    File,
    // Crap, we need to recompile
    // all of consumers of `LogType`
    Monitor
}
