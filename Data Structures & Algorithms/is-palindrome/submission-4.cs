public class Solution {
    public bool IsPalindrome(string s) {

        int l = 0, r = s.Length - 1;

        while (l < r)
        {
            while (l < r && !IsAlphaNumeric(s[l]))
            {
                l++;
            }

            while (r > l && !IsAlphaNumeric(s[r]))
            {
                r--;
            }

            if (char.ToLower(s[r]) != char.ToLower(s[l]))
            {
                return false;
            }

            r--; 
            l++;
        }

        return true;
    }

        public bool IsAlphaNumeric(char c)
    {
        if ( (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9') )
        {
            return true;
        }

        else return false;
    }
}
