public class Solution {
    public int EvalRPN(string[] tokens)
    {
                Stack<int> nums = new Stack<int>();
            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i] =="+")
                    nums.Push(nums.Pop() + nums.Pop());
                else if(tokens[i] =="-") 
                    nums.Push(-1*(nums.Pop() - nums.Pop()));
                else if(tokens[i] =="*")
                    nums.Push(nums.Pop() * nums.Pop());
                else if(tokens[i] =="^")
                {
                    int num2 = nums.Pop() , num1 = nums.Pop();
                    nums.Push( (int) Math.Pow(num1 , num2));
                }
                else if (tokens[i] =="/")
                {
                    int num2 = nums.Pop(), num1 = nums.Pop();
                    nums.Push(num1 / num2);
                }
                else
                    nums.Push(int.Parse(tokens[i]));
            }
            return nums.Pop();    
    }
}
