public class Solution {
    public int MaxArea(int[] heights) {
                int l = 0, r = heights.Length - 1, result = 0, temp , x,y;
                while (l < r )
                {
                    temp = Math.Min(heights[l], heights[r]) * (r-l);
                    if(temp > result)
                        result = temp;
                    if (heights[l] == heights[r])
                    {
                        x = l + 1;
                        y = r - 1;
                        while (x < y  && heights[x] == heights[y] && heights[x] < heights[l])
                        {
                            x++;
                            y--;
                        }
                        l = x;
                        r = y;
                    }
                    else if(heights[l] < heights[r])
                    {
                         x = l + 1;
                        while (x < r && heights[x] < heights[l])
                        {
                            x++;
                        }
                        l = x;
                    }
                    else
                    {
                         x = r - 1;
                        while (l < x && heights[r] > heights[x])
                        {
                            x--;
                        }
                        r = x;
                    }
                }
                return result;

    }
}
