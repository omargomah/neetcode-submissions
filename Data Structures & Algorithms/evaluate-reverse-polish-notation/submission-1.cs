public class Solution {
    public int EvalRPN(string[] tokens) {
                        Stack<int> s = new Stack<int>();
                foreach (var item in tokens)
                {
                    if (int.TryParse(item, out int num))
                        s.Push(num);
                    else 
                    {
                        int num2 = s.Pop() , num1 = s.Pop(), result = 0;
                        switch (item)
                        {
                            case "+":
                                result = num1 + num2;
                                break;
                            case "-":
                                result = num1 - num2;
                                break;
                            case "*":
                                result = num1 * num2;
                                break;
                            case "/":
                                result = num1 / num2;
                                break;
                            default:
                                break;
                        }
                        s.Push(result);
                    }
                }
                return s.Pop() ;
    }
}
