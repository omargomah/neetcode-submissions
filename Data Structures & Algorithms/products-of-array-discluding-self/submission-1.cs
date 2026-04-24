public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
                        int length = nums.Length;
                int[] right = new int[length + 1];
                right[length] = 1;
                int[] left = new int[length + 1];
                left[0] = 1;
                for (int i = 0; i < length; i++)
                {
                    left[i+1] = left[i] * nums[i];
                    right[length - 1 - i] = right[length - i] * nums[ length - 1 - i];
                }
                int [] result = new int[length];
                for(int i =0; i< length; i++)
                {
                    result[i] = left[i] * right[i+1];
                }
                return result;

    }
}
