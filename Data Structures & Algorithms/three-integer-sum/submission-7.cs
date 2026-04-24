public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
           int l, r,target,sum;
   List<List<int>> list = new List<List<int>>();
   Dictionary<int,int> dict = new Dictionary<int, int>();
   HashSet<int> set = new HashSet<int>();
   List<int> order = new List<int>();
   for (int i = 0; i < nums.Length; i++)
       dict[nums[i]] = i;
   for (int i = 0; i < nums.Length; i++)
   {
       l = 0;
       r = nums.Length -1;
       target = -nums[i];
       for (int j = 0; j < nums.Length;j++)
       {
           if (j == i)
               continue;
           if (dict.ContainsKey(target - nums[j]) && dict[target - nums[j]] != i && dict[target - nums[j]] != j)
           {
               order=[nums[i], nums[j], target - nums[j]];
               var result = order.Order().ToList();
               var hash = HashCode.Combine(result[0], result[1], result[2]);
               if (!set.Contains(hash))
               {
                   set.Add(hash);
                   list.Add([nums[i],nums[j], target - nums[j]]);
               }
           }
       }
   }
   return list;
    }
}
