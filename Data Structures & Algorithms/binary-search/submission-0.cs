public class Solution {
    public int Search(int[] nums, int target)
    {
                int l = 0, mid, r = nums.Length - 1;
        while (l <= r)
        {
            mid = (l + r) / 2;
            if (nums[mid] < target)
                l = mid + 1;
            else if (nums[mid] > target)
                r = mid - 1;
            else
                return mid;
        }
        return -1;
    }
}
