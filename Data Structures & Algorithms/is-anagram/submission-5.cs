public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach (char c in s) {
            if (!dict.ContainsKey(c)) {
                dict.Add(c, 1);
            } else {
                dict[c]++;
            }
        }

        foreach (char c in t) {
            if (!dict.ContainsKey(c) || dict[c] == 0) {
                return false;
            } else {
                dict[c]--;
            }
        }

        if(dict.Any(k => k.Value != 0)){
            return false;
        }
        return true;
    }
}
