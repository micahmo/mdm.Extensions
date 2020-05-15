namespace mdm.Extensions
{
    /// <summary>
    /// Defines a set of extensions methods that can be used on any <see cref="object"/>.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Returns <see langword="true"/> if the given <paramref name="object"/> is equal to <see langword="null"/>
        /// (according to the <see langword="is"/> operator), otherwise <see langword="false"/>.
        /// </summary>
        public static bool IsNull(object @object)
        {
            return @object is null;
        }

        /// <summary>
        /// Returns <see langword="true"/> if the given <paramref name="object"/> is not equal to <see langword="null"/>
        /// (according to the <see langword="is"/> operator), otherwise <see langword="false"/>.
        /// </summary>
        public static bool IsNotNull(object @object)
        {
            return @object is null == false;
        }
    }
}
