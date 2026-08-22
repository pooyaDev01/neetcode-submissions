public class Solution {
    public bool IsValid(string s) {
                Stack<char> stack = new Stack<char>();
        Dictionary<char, char> maps = new Dictionary<char, char>()
        {
            {')' , '(' },
            {']' , '[' },
            {'}' , '{' }
        };

        foreach (char c in s)
        {
            if (maps.ContainsKey(c))
            {
                if (stack.Count > 0 && stack.Peek() == maps[c])
                {
                    stack.Pop();
                }

                else
                {
                    return false;
                }
            }

            else
            {
                stack.Push(c);
            }
        }

        if (stack.Count == 0)
        {
            return true;
        }

        else
        {
            return false;
        }
    }
}
