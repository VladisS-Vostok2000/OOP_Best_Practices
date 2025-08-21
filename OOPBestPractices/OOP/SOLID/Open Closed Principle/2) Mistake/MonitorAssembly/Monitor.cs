namespace OOPBestPractices.OOP.SOLID.OpenClosedPrinciple.MonitorAssembly;
public static class Monitor {
    public static void Log(string log) {
        // Simulating logging
        // as common domain logic
        try {
            Console.Write(log);
        }
        catch (Exception ex) {
            using StreamWriter writer = new("error.log");
            writer.WriteLine($"{ex.Message}");
            throw new Exception("Logging error", ex);
        }
    }
}
