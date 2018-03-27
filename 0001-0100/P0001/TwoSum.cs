namespace P0001
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (var slowerIndex = 0; slowerIndex < nums.Length; slowerIndex++)
            {
                for (var fasterIndex = slowerIndex + 1; fasterIndex < nums.Length; fasterIndex++)
                {
                    if (nums[slowerIndex] + nums[fasterIndex] == target)
                        return new[] { slowerIndex, fasterIndex };
                }
            }
            return null;
        }
    }
}