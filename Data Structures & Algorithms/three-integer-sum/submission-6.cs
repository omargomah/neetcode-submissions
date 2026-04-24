public class Solution {
    public List<List<int>> ThreeSum(int[] nums)
    {
            List<List<int>> lst = new List<List<int>>();
        Array.Sort(nums);
        int x =0 , l , r;
        if (nums[x] > 0) return lst;
        while(x < nums.Length-2 )
        {
            l = x+1;r = nums.Length - 1;
                        List<int> check = new List<int>();
            while(l<r)
            {
                if (nums[x] + nums[l] + nums[r] == 0)
                {
                    if (!(check.Contains(nums[l]) && check.Contains(nums[r])))
                    {
                        lst.Add(new List<int>() { nums[x] , nums[l] , nums[r] });
                        check.Add(nums[l]);
                        check.Add(nums[r]);
                    }
                    l++; r--;
                }
                else if(nums[x] + nums[l] + nums[r] > 0)
                    r--;
                else
                    l++;
            }
            while ( (x < nums.Length-2)  && (nums[x] == nums[x+1]))
                x++;
            x++;
        }
        return lst;    
    }
}
