namespace OOPBestPractices.OOP.SOLID.OpenClosedPrinciple.LoggingAssembly.Abstractions;
// Defining common interface
// in separately assembly
// so we never need now
// to recompile injection
// consumers anymore
public interface ILogger {
    public void Log(string log);
}
