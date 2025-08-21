global using OOPBestPractices.OOP.SOLID.OpenClosedPrinciple.MonitorAssembly.Internal;

namespace OOPBestPractices.OOP.SOLID.OpenClosedPrinciple.MonitorAssembly;
public static class Monitor {
    // Implementing new runtime injection logic
    public static MonitorLogger? MonitorLogger { get; set; }



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

            if (type == LogType.Monitor) {
                MonitorLogger?.Equals(log);
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

        // Nah: logger type checking
        // is keeping dublicating
        // For large projects that will
        // cause a tons of changes
        // at each addition/remove
        if (type == LogType.Monitor) {
            MonitorLogger?.Close();
        }
    }
}