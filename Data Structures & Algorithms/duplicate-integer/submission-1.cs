public class Solution {
    public bool hasDuplicate(int[] nums) {
                        var x = nums.Order().ToList();
                for (int i = 1; i < x.Count; i++)
                {
                    if (x[i] == x[i - 1])
                        return true;
                }
                return false;
    }
}