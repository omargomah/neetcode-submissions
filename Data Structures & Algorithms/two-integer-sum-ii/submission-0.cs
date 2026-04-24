public class Solution {
    public int[] TwoSum(int[] numbers, int target) 
    {
             int l = 0 , r = numbers.Length - 1;
        while(true)
        {
            if (numbers[l] + numbers[r] > target)
                r--;
            else if (numbers[l] + numbers[r] < target)
                l++;
            else
                break;
        }
        return new int[] {l+1, r+1};   
    }
}
