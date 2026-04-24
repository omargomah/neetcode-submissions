public class Solution {
    public int FindMin(int[] nums) {
                int l = 0, r = nums.Length - 1, mid = nums[0] , min = int.MaxValue;
                while (r>=l)
                {
                    mid = (l + r) / 2;
                    if (nums[l] < nums[r])
                    {
                        if (nums[l] < min)
                            min = nums[l];
                        break;
                    }
                    if (nums[mid] < min )
                        min = nums[mid];                        
                    if (nums[mid] >= nums[l])
                        l = mid + 1;
                    else
                        r = mid - 1;
                }
                return min;

    }
}
