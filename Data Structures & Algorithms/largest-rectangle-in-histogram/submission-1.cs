public class Solution {
    public int LargestRectangleArea(int[] heights) 
    {
            int maxHeight = heights.Max() , maxArea = 0;
        for (int i = 1; i <= maxHeight; i++)
        {
            int counter = 0 , maxlength = int.MinValue;
            for (int j = 0;j < heights.Length; j++)
            {
                if(heights[j] >=  i)
                    counter++;
                else
                {
                    if(counter > maxlength)
                        maxlength = counter;
                    counter = 0;
                }
            }
            if (counter > maxlength)
                maxlength = counter;
            if (i* maxlength > maxArea)
                maxArea = i * maxlength;
        }
        return maxArea;    
    }
}
