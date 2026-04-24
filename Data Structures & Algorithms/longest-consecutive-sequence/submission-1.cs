public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
                if(nums.Length == 0) return 0;
            else
            {
                Array.Sort(nums);
                int temp = 1 , length = int.MinValue;
                for (int i = 1; i < nums.Length; i++)
                {
                    if(nums[i] == nums[i-1])
                        continue;
                    else if (nums[i] == nums[i-1]+1)
                        temp++;
                    else
                    {
                        if(temp > length )
                            length = temp;
                        temp = 1;
                    }
                }
                return length > temp ? length : temp ;
            }    
    }
}
