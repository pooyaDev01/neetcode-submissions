public class Solution {
    public int LongestConsecutive(int[] nums) {
                Dictionary<int, int> dict = new Dictionary<int, int>();

        int result = 0;

        foreach (var n in nums)
        {
            if (!dict.ContainsKey(n))
            {
                dict[n] = (dict.ContainsKey(n - 1) ? dict[n - 1] : 0) +
                          (dict.ContainsKey(n + 1) ? dict[n + 1] : 0) + 1;

                dict[n - (dict.ContainsKey(n - 1) ? dict[n - 1] : 0)] = dict[n];
                dict[n + (dict.ContainsKey(n + 1) ? dict[n + 1] : 0)] = dict[n];
            }

            result = Math.Max(result, dict[n]);
        }

        return result;
    }
}
