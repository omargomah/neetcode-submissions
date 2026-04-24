public class Solution {
    public bool IsValid(string s) {
                    Stack<char> stack = new Stack<char>();
            Dictionary<char,char> dict = new Dictionary<char, char>();
            dict[')'] = '(';
            dict['}'] = '{';
            dict[']'] = '[';

            foreach (var item in s)
            {
                if (dict.Any(x => x.Value == item))
                    stack.Push(item);
                else 
                {
                    if(stack.Count == 0)
                        return false;
                    if (!(dict[item] == stack.Peek()))
                        return false;
                    stack.Pop();
                }
            }
            return stack.Count == 0 ;

    }
}
