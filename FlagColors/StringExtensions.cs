
namespace FlagColors
{
    public static class StringExtensionsClass
    {
        public static int CustomIndexOf(this string str, string value, int startIndex, int amountToSkip = 0, StringComparison culture = StringComparison.InvariantCulture)
        {
            int index = -1;
            while (amountToSkip-- >= 0)
            {
                index = str.IndexOf(value, startIndex, culture);
                if (index < 0)
                    return index;
                startIndex = index + 1;
            }
            return index;
        }
    }
}
