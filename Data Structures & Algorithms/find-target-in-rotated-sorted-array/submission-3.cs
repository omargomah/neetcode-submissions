public class Solution {
    public int Search(int[] nums, int target) 
    {
            int l = 0, r = nums.Length-1, mid;
        while (l < r-1)
        {
            mid =(l+r)/2 ;
            if( nums[mid] == target)
                return mid;
            else if(nums[mid] < target)
            {
                if (nums[l] < nums[mid])
                    l = mid;
                else
                {
                    if(nums[r] == target)
                        return r;
                    else if(nums[r] > target)
                        l = mid;
                    else 
                        r = mid;
                }
            }
            else
            {
                if (nums[l] < nums[mid])
                {
                    if (nums[l] > nums[r])
                    {
                        if (nums[l] == target)
                            return l;
                        else if (nums[l] < target)
                            r = mid;
                        else 
                            l = mid;
                    }
                    else
                        r = mid;
                }
                else
                    r = mid;
            }
        }
        return nums[l] == target ? l : (nums[r] == target? r: -1);    
    }
}
