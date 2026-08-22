public class Solution {
    public bool IsPalindrome(string s) {

        StringBuilder stringBuilder = new StringBuilder();

        foreach (char c in s)
        {
            if ( IsAlphaNumeric(c) == true)
            {
                stringBuilder.Append(char.ToLower(c));
            }

            else
            {
                continue;
            }
        }
        
        string s2 = stringBuilder.ToString();

        int index = s2.Length - 1;

        for(int i = 0; i < s2.Length / 2 && index >= 0; i++)
        {
            if (s2[i] == s2[index--])
            {
                continue;
            }

            else
            {
                return false;
            }
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
