namespace Snake_WPF.Logic.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string @string)
        {
            return @string is null || @string == string.Empty;
        }
    }
}
