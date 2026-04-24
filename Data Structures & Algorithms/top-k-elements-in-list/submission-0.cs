public class Solution 
{
    public int[] TopKFrequent(int[] nums, int k) 
    {
        Array.Sort(nums);
        SortedList<int ,int> frq = new SortedList<int ,int>();
        frq.Add(nums[0], 1);
        for (int i = 1 ; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
                frq[nums[i]]++;
            else
                frq.Add(nums[i], 1);
        }
        var orderedLst =  frq.OrderByDescending(kvb => kvb.Value).ToList();
        int[] solution = new int[k];
        int index = 0;
        foreach (var item in orderedLst)
        {
            if(k == index)
                break;
            solution[index] = item.Key;
            index++;
        }
        return solution;
    }
}
