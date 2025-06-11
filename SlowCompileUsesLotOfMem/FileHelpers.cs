namespace SlowCompileUsesLotOfMem;

public static class FileHelpers
{
    public static string GetAbsolutePath(string path)
    {

        if (!Path.IsPathRooted(path)) // Is relative path?
        {
            path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
        }

        return Path.GetFullPath(path);
    }

}