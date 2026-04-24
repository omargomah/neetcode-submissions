public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) 
    {
            bool Search(int[] nums, int target)
        {
            int l = 0, mid, r = nums.Length - 1;
            while (l <= r)
            {
                mid = (l + r) / 2;
                if (nums[mid] < target)
                    l = mid + 1;
                else if (nums[mid] > target)
                    r = mid - 1;
                else
                    return true;
            }
            return false;
        }
        int l = 0 , mid , r = matrix.Length-1;
        while(l <= r)
        {
            mid = (l + r) / 2;
            if (matrix[mid][0]  > target)
                r = mid - 1;
            else if(matrix[mid][0] < target)
            {
                l = mid + 1;
                if(matrix[mid][matrix[mid].Length- 1] == target)
                    return true;
                else if(matrix[mid][matrix[mid].Length - 1] > target)
                    return Search(matrix[mid], target);
            }
            else
                return true;
        }
        return false;    
    }
}
