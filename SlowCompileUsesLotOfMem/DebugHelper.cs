namespace SlowCompileUsesLotOfMem;

public class DebugHelper
{
    public static void WriteLine(string s) => Console.WriteLine(s);
    public static void WriteException(string ex) => Console.Error.WriteLine(ex);
    public static void WriteException(Exception ex) => WriteException(ex.ToString());
}