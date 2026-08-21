public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
                Dictionary<string,List<string>> dict = new Dictionary<string,List<string>>();

        foreach (var s in strs)
        {
            int[] count = new int[26];

            foreach (char c in s)
            {
                count[c - 'a']++;
            }

            string key = string.Join(',', count);

            if (!dict.ContainsKey(key))
            {
                dict.Add(key, new List<string>());
            }

            dict[key].Add(s);
        }

        return dict.Values.ToList();
    }
}
