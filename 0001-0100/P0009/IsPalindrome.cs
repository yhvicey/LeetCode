using System;

namespace P0009
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            long origin = x;
            long compare = 0;
            while (x != 0)
            {
                compare = compare * 10 + x % 10;
                x /= 10;
            }
            return compare == Math.Abs(origin);
        }
    }
}
