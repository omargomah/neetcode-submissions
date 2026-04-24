public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
            SortedList<int,int> lst = new SortedList<int,int>();
            for (int i = 0; i < nums.Length;i++)
                lst.Add(i, nums[i]);
            var sotedLst = lst.OrderBy(key => key.Value).ToList();
            int x = 0 , y = nums.Length-1 ;
            while (true)
            {
                if (sotedLst[x].Value + sotedLst[y].Value == target)
                    break;
                else if (sotedLst[x].Value + sotedLst[y].Value > target)
                    y--;
                else
                    x++;
            }
            return new int[] { Math.Min( sotedLst[x].Key, sotedLst[y].Key) , Math.Max(sotedLst[x].Key, sotedLst[y].Key) };
    }
}
