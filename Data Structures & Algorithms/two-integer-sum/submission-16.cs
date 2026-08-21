public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];

            if (keyValuePairs.ContainsKey(diff))
            {
                return new int[] {keyValuePairs[diff],i};
            }

            else
            {
                keyValuePairs[nums[i]] = i;
            }
        }
        return null;
    }
}
