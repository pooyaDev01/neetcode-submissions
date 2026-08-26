public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
        foreach (var str in strs) {
            int[] counts = new int[26];
            for (int i = 0; i < str.Length; i++) {
                counts[str[i] - 'a']++;
            }

            string key = string.Join(",", counts);
            if (!dic.ContainsKey(key)) {
                dic.Add(key, new List<string>());
            }
            dic[key].Add(str);
        }
        return dic.Values.ToList();
    }
}
