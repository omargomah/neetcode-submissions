public class Solution {
    public int MaxArea(int[] heights) 
    {
    int maxAmount = int.MinValue , l = 0 , r = heights.Length -1 ;
while (l < r)
{
    if (int.Min(heights[l], heights[r]) * (r - l) > maxAmount)
        maxAmount = int.Min(heights[l], heights[r]) * (r - l);
    if (heights[l] < heights[r])
        l++;
    else
        r--;
}
return maxAmount;    
    }
}
