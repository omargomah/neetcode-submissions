public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
                int l = 0, r = matrix.Length-1, mid =0;
                while (r >= l) 
                {
                    mid = (l + r) / 2;
                    if (matrix[mid][0] > target)
                        r = mid - 1;
                    else if (matrix[mid][0] < target)
                         l = mid + 1;
                    else
                        return true;
                }
                                int row = matrix[mid][0] > target ? mid == 0? 0: mid-1 : mid ;

                l = 0;
                r = matrix[mid].Length - 1;
                mid=0;
                while (r >= l)
                {
                    mid = (l + r) / 2;
                    if (matrix[row][mid] > target)
                        r = mid - 1;
                    else if (matrix[row][mid] < target)
                        l = mid + 1;
                    else
                        return true;
                }
                return false;

    }
}
