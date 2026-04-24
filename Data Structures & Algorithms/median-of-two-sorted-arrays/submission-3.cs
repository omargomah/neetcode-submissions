public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
                if(nums1.Length < nums2.Length)
                {
                    int[] temp  = nums1;
                    nums1 = nums2;
                    nums2 = temp;
                }

                int l = 0  , r= nums1.Length - 1,mid , half = (nums1.Length + nums2.Length)/2 , Lnum1, Lnum2, Rnum1, Rnum2;
                if (nums1.Length == 0)
                    return nums2.Length % 2 == 0 ? (nums2[nums2.Length/2]+ nums2[nums2.Length / 2 - 1])/(double)2 : nums2[nums2.Length / 2];
                if (nums2.Length == 0)
                    return nums1.Length % 2 == 0 ? (nums1[nums1.Length / 2] + nums1[nums1.Length / 2 - 1]) / (double)2 : nums1[nums1.Length / 2];
                bool IsEven = (nums1.Length + nums2.Length) % 2 == 0 ? true : false; 
                while (true)
                {
                    mid = (l + r) / 2;
                    Lnum1 = mid >= 0 ? nums1[mid]: int.MinValue;
                    Lnum2 = half - (mid + 2) >=0 ? nums2[half - (mid + 2)] : int.MinValue;
                    Rnum1 = mid + 1 >= nums1.Length ? int.MaxValue :nums1[mid+1];
                    Rnum2 = half - (mid + 1) > nums2.Length ? int.MaxValue : nums2[half - (mid + 1)];
                    if (Lnum1 <= Rnum2 && Lnum2 <= Rnum1)
                    {
                        if (IsEven)
                            return (Math.Max(Lnum1, Lnum2) + Math.Min(Rnum1,Rnum2)) / (double)2;
                        else
                            return Math.Min(Rnum1, Rnum2);
                    }
                    if(Lnum1 > Rnum2)
                        r = mid-1;
                    else if(Lnum2 > Rnum1)
                        l = mid+1;   
                }

    }
}
