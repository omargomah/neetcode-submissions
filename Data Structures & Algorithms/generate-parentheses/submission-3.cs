public class Solution {  
    public List<string> GenerateParenthesis(int n)
    {
List<string> lst = new List<string>();
void getList(int open = 0, int close = 0, string result = "")
{
    if (open == n && close == n)
        lst.Add(result);
    else
    {
        if (open < n)
        {
            open++;
            getList(open, close, result + '(');
            open--;
        }
        if (close < open && close <= n)
        {
            close++;
            getList(open, close, result + ')');
            close--;
        }
    }
}
getList();
return lst;
    }
}
