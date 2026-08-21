public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
                Dictionary<int,int> dict = new Dictionary<int,int>();
        List<int>[] freq = new List<int>[nums.Length+1];

        foreach (var num in nums)
        {
            if (!dict.ContainsKey(num))
            {
                dict.Add(num, 1);
            }

            else
            {
                dict[num]++;
            }
        }

        for (int i = 0;i < freq.Length; i++)
        {
            freq[i] = new List<int>();
        }

        foreach (var pair in dict)
        {
            freq[(pair.Value)].Add(pair.Key);
        }

        int[] result = new int[k];

        int index = 0;

        for (int i = freq.Length-1; i > 0 && index < k; i--)
        {
            foreach (var num in freq[i])
            {
                result[index++] = num;

                if(index == k)
                {
                    return result;
                }
            }
        }

        return result;
    }
}
