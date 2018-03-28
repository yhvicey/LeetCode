using System;

namespace P0003
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var indexTable = new int[256];
            for (var i = 0; i < indexTable.Length; i++)
                indexTable[i] = -1;

            var length = 0;
            var startIndex = 0;
            var currentLength = 0;
            for (var i = 0; i < s.Length; i++)
            {
                currentLength++;
                var lastIndex = indexTable[s[i]];
                indexTable[s[i]] = i;
                if (lastIndex >= startIndex)
                {
                    length = Math.Max(length, currentLength - 1);
                    startIndex = lastIndex + 1;
                    currentLength = i - startIndex + 1;
                }
            }
            length = Math.Max(length, currentLength - 1);
            return length;
        }
    }
}
