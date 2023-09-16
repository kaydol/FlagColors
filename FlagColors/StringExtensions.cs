using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions
{
    public static class StringExtensionsClass
    {
        public static int CustomIndexOf(this string str, string value, int startIndex, int amountToSkip = 0)
        {
            int index = -1;
            while (amountToSkip-- >= 0)
            {
                index = str.IndexOf(value, startIndex);
                if (index < 0)
                    return index;
                startIndex = index + 1;
            }
            return index;
        }
    }
}
