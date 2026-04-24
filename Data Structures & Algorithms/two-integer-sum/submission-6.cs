public class Solution {
    public int[] TwoSum(int[] nums, int target) {
                Dictionary<int,int> values = new Dictionary<int,int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if(values.ContainsKey(target - nums[i]))
                        return [values[target - nums[i]],i];
                    values[nums[i]] = i;
                }
                return null!;
    }
}
