public class Solution {
    public int FindDuplicate(int[] nums) {
                     int i = 0, j = 0 ;
                while (true)
                {
                    i = nums[i];
                    j = nums[nums[j]];
                    if (i == j)
                    {
                        i = 0;
                        while (true)
                        { 
                            if (i == j)
                                return i; 
                            i = nums[i];
                            j = nums[j];
                        }
                    }
                }
    }
}
