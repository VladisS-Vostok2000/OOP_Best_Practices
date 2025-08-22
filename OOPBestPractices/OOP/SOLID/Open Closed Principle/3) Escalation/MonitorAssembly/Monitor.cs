global using OOPBestPractices.OOP.SOLID.OpenClosedPrinciple.MonitorAssembly.Internal;

namespace OOPBestPractices.OOP.SOLID.OpenClosedPrinciple.MonitorAssembly;
public static class Monitor {
    public static void Log(LogType type, string log) {
        // Simulating logging
        // as common domain logic
        try {
            if (type == LogType.None) {
                return;
            }

            if (type == LogType.Console) {
                Console.Write(log);
            }

            if (type == LogType.File) {
                FileLogger.Log(log);
            }
        }
        catch (Exception ex) {
            throw new Exception("Logging error", ex);
        }
    }

    public static void Close(LogType type) {
        if (type == LogType.File) {
            FileLogger.Close();
        }
    }
}