public class Solution {
    public int Trap(int[] height) {
                        int l = 0 , r = height.Length -1 , maxLeft = 0, maxRight = 0, result = 0 , i = 0 ;
                bool IsLeft;
                while (l <= r) 
                {
                    IsLeft = false;
                    if (maxLeft <= maxRight)
                    {
                        i = l;
                        l++;
                        IsLeft = true;
                    }
                    else
                    { 
                        i = r;
                        r--;
                    }
                    if (Math.Min(maxLeft, maxRight) - height[i] > 0)
                        result += Math.Min(maxLeft, maxRight) - height[i];
                    if (IsLeft)
                        maxLeft = Math.Max(maxLeft, height[i]);
                    else
                        maxRight = Math.Max(maxRight, height[i]);
                }
                return result;

    }
}
