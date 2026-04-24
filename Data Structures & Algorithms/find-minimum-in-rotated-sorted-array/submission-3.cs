public class Solution {
    public int FindMin(int[] nums) 
    {
             int l = 0 , r = nums.Length-1 , mid;
        while (l < r-1)
        {
            mid = (l+r)/2 ;
            if(nums[l] < nums[mid])
            {
                if (nums[l] > nums[r])
                    l = mid;
                else
                    r = mid;
            }
            else
                r = mid;
        }
        return Math.Min(nums[l], nums[r]);   
    }
}
