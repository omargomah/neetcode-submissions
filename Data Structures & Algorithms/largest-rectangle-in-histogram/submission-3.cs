public class Solution {
    public int LargestRectangleArea(int[] heights) {
                Stack<(int,int)> s = new Stack<(int, int)>();
                Stack<int> area = new Stack<int>();
                for (int i = 0; i < heights.Length; i++)
                {
                    int start = i;
                    while (s.Count != 0 && s.Peek().Item1 > heights[i])
                    {
                        area.Push(s.Peek().Item1*(i-s.Peek().Item2));
                        start = s.Peek().Item2;
                        s.Pop();
                    }
                    s.Push((heights[i],start));
                }
                while (s.Count != 0)
                {
                    area.Push(s.Peek().Item1 * (heights.Length - s.Peek().Item2));
                    s.Pop();
                }
                int maxArea = 0;
                
                while (area.Count != 0)
                { 
                    if(area.Peek() > maxArea)
                        maxArea = area.Peek();
                    area.Pop();
                }
                return maxArea;

    }
}
