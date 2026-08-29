public class Solution {
    public string Encode(IList<string> strs) {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (var str in strs) {
            stringBuilder.Append(str.Length);
            stringBuilder.Append('#');
            stringBuilder.Append(str);
        }
        return stringBuilder.ToString();
    }

    public List<string> Decode(string s) {
        List<string> strs = new List<string>();
        int i = 0;
        while (i < s.Length) {
            int j = i;
            while (s[j] != '#') {
                j++;
            }
            int length = Convert.ToInt32(s.Substring(i, j - i));
            i = j + 1;
            strs.Add(s.Substring(i, length));
            j = i + length;
            i = j;
        }
        return strs;
    }
}
