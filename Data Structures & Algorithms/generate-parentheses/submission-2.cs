public class Solution {  
        List<string>  lst = new List<string>();
        public List<string> GenerateParenthesis(int n)
        {
            getList(n);
            return lst;
        }
            void getList(int n, int open = 0, int close = 0, string result = "" )
            {
                if (open == n && close == n)
                    lst.Add(result);
                else
                {
                    if(open < n)
                    {
                        open++;
                        getList(n,open,close,result+'(');
                                                open--;
                    }
                    if (close < open && close <= n )
                    {
                        close++;
                        getList(n, open, close, result + ')');
                                                close--;
                    }
                }
            }
}
