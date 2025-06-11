public static class StringExtensions
{
    public static string ParseQuoteString(this string str)
    {
        str = str.Trim();

        var firstQuote = str.IndexOf('"');

        if (firstQuote < 0) return str;
        str = str.Substring(firstQuote + 1);

        var secondQuote = str.IndexOf('"');

        if (secondQuote >= 0)
        {
            str = str.Remove(secondQuote);
        }

        return str;
    }
}