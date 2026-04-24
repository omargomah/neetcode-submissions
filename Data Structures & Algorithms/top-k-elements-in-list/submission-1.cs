public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
                                   Dictionary<int,int> dict = new Dictionary<int,int>();
                foreach (var item in nums)
                {
                    if(!dict.ContainsKey(item))
                        dict[item] = 0;
                    dict[item]++;
                }
                return dict.OrderByDescending(x => x.Value).Select(x => x.Key).ToArray()[..k];

    }
}
