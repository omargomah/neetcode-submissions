public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
                 Stack<(int,int)> s = new Stack<(int, int)> ();
                int[] result = new int[temperatures.Length]; 
                result[temperatures.Length - 1] = 0;
                s.Push((temperatures[temperatures.Length-1], temperatures.Length - 1));
                for (int i = temperatures.Length - 2; i > -1 ; i--)
                { 
                    while (s.Count != 0 && s.Peek().Item1 <= temperatures[i])
                    {
                        s.Pop();
                    }
                    result[i] = s.Count == 0 ? 0 : s.Peek().Item2 - i ;
                    s.Push((temperatures[i],i));
                }
                return result ;

    }
}
