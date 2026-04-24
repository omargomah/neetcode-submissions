public class Solution {
    public int[] TwoSum(int[] nums, int target) {
                                        List<(int,int)> keyValuePairs = new List<(int, int)>(nums.Length);
                for (int i = 0; i< nums.Length; i++)
                    keyValuePairs.Add((i,nums[i]));
                 var sortedDict = keyValuePairs.OrderBy(x=> x.Item2).ToList();
                int l = 0 , r = nums.Length - 1 , sum;
                while (true) 
                {
                    sum = sortedDict[l].Item2 + sortedDict[r].Item2; 
                    if (sum > target)
                        r--;
                    else if (sum < target)
                        l++;
                    else
                    {
                        var lnums = sortedDict[l].Item1; 
                        var rnums = sortedDict[r].Item1;
                        return lnums > rnums ?  [rnums ,lnums ] : [lnums,rnums];
                    }                    
                }
    }
}
