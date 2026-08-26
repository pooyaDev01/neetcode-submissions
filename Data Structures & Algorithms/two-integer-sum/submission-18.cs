public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new();
        for (int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];
            if (!dict.ContainsKey(diff)) {
                dict.Add(nums[i], i);
            } else {
                return new int[] { dict[diff], i };
            }
        }
        throw new Exception("Error");
    }
}
