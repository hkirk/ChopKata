using System;

namespace Recursive
{
    public class Chop
    {

        public static int chop(int needle, int[] haystack)
        {
            return chopRecursive(needle, haystack, 0, haystack.Length);
        }

        private static int chopRecursive(int needle, int[] haystack, int startIndex, int endIndex)
        {
            int size = endIndex - startIndex;
            if (size == 1 && haystack[startIndex] == needle)
            {
                return startIndex;
            }

            if (size <= 1) return -1;

            int centerIndex = ((endIndex - startIndex) / 2) + startIndex;
            if (haystack[centerIndex] == needle) return centerIndex;
            if (haystack[centerIndex] > needle)
            {
                return chopRecursive(needle, haystack, startIndex, centerIndex);
            }
            else
            {
                return chopRecursive(needle, haystack, centerIndex, endIndex);
            }
        }
    }
}