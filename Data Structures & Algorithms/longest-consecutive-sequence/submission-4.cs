public class Solution {
    public int LongestConsecutive(int[] nums) {
                        HashSet<int> set = new HashSet<int>();
                List<int> start = new List<int>();
                foreach (var item in nums)
                {
                    set.Add(item);
                }
                for (int i = 0; i < nums.Length; i++) 
                {
                    if (!set.Contains(nums[i]-1))
                    {
                        start.Add(nums[i]);
                    }
                }
                int result = 0;
                foreach(int item in start)
                {
                    int count = 0;
                    int next = item;
                    while (set.Contains(next++))
                    {
                        count++;
                    }
                    if(count > result)
                        result = count;
                }
                return  result;

    }
}
