public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
                 List<int> zero = new List<int>();
            int[] arr = new int[nums.Length];
            int temp = 1;
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == 0)
                    zero.Add(i);
                else
                    temp *= nums[i];
            }
            for(int i = 0;i < nums.Length; i++)
            {
                if(zero.Count > 1)
                    arr[i] = 0;
                else if(zero.Count == 1)
                {
                    if(zero.Contains(i))
                        arr[i] = temp ;
                    else
                        arr[i] = 0;
                }
                else
                    arr[i] = temp / nums[i] ;
            }
            return arr;   
    }
}
