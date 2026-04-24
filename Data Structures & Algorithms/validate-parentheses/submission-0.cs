public class Solution {
    public bool IsValid(string s) 
    {
                 Stack<char> open = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '[' || s[i] == '(' || s[i] == '{')
                    open.Push(s[i]);
                else
                {
                    if(open.Count == 0) return false;
                    else
                    {
                        if (s[i] == ']')
                        {
                            if(open.Pop() != '[')
                                return false;
                        }
                        else if(s[i] == '}')
                        {
                            if (open.Pop() != '{')
                                return false;
                        }
                        else
                        {
                            if (open.Pop() != '(')
                                return false;
                        }
                    }
                }
            }
            if(open.Count != 0) return false;
            return true;   
    }
}
