namespace Iterative
{
    public class Chop
    {
        public static int chop(int needle, int[] haystack)
        {
            var startIndex = 0;
            var endIndex = haystack.Length;
            while (endIndex - startIndex > 1)
            {
                var centerIndex = (endIndex - startIndex) / 2 + startIndex;
                if (haystack[centerIndex] == needle) return centerIndex;
                if (haystack[centerIndex] > needle)
                {
                    endIndex = centerIndex;
                }
                else
                {
                    startIndex = centerIndex;
                }
            }
            
            if (haystack.Length > startIndex && haystack[startIndex] == needle) return startIndex;
            
            return -1;
        }
    }
}