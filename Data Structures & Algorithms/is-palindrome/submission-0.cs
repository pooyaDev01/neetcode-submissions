public class Solution {
    public bool IsPalindrome(string s) {

        string s2 = s.Trim();

        StringBuilder stringBuilder = new StringBuilder();

        foreach (char c in s2)
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
        
        string s3 = stringBuilder.ToString();

        int index = s3.Length - 1;

        for(int i = 0; i < s3.Length / 2 && index >= 0; i++)
        {
            if (s3[i] == s3[index--])
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
