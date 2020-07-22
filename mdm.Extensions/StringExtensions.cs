namespace mdm.Extensions
{
    /// <summary>
    /// Defines a set of extension methods that can be used on any <see cref="string"/>.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Returns <see langword="true"/> if the given <paramref name="string"/> is not null or empty
        /// (according to <see cref="string.IsNullOrEmpty(string)"/>), otherwise <see langword="false"/>.
        /// </summary>
        public static bool IsNotNullOrEmpty(this string @string)
        {
            return string.IsNullOrEmpty(@string) == false;
        }
    }
}
