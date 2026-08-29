public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] arr = new int[nums.Length];

        Array.Fill(arr, 1);

        for (int i = 1; i < nums.Length; i++)
        {
            arr[i] = arr[i - 1] * nums[i - 1];
        }

        int postfix_index = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            arr[i] *= postfix_index;
            postfix_index *= nums[i];
        }
        return arr;
    }
}
