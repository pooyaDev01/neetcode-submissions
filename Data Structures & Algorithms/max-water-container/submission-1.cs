public class Solution {
    public int MaxArea(int[] heights) {
        int max = 0;

        int r = heights.Length - 1;

        int l = 0;

        int area = 0;

        while (l < r)
        {
            area = Math.Min(heights[l], heights[r]) * (r - l);

            if (area > max)
            {
                max = area;
            }

            if (heights[l] > heights[r])
            {
                r--;
            }

            else
            {
                l++;
            }
        }

        return max;
    }
}
