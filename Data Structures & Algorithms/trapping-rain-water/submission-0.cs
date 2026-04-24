public class Solution {
    public int Trap(int[] height)
     {
            int amount = 0, l = 0, r = 0;
        while( r < height.Length - 1)
        {
            if (height[r] >= height[r + 1])
                r++;
            else if (height[r] < height[r + 1])
            {
                r++;
                int index = l+1, realHeight = int.Min(height[r], height[l]);
                while (index < r)
                {
                    if(realHeight > height[index])
                    {
                        amount += (realHeight - height[index]);
                        height[index] = realHeight;
                    }
                    index++;
                }
                if(height[l] < height[r])
                    l = r;
            }
        }
        return amount;    
    }
}
