public class Solution {
    public int MinEatingSpeed(int[] piles, int h) 
    {
             int l = 1 , r = piles.Max()  , mid ;
        int result = int.MaxValue;
        while (l <= r)
        {
            mid = (l + r) / 2;
            int counter = 0;
            for (int i = 0 ; i < piles.Length ; i++)
                counter += (int) Math.Ceiling(piles[i] / (double) mid);
            if(counter > h)
            {
                l = mid + 1;
            }
            else if(counter < h )
            {
                if(result > mid)
                    result = mid;
                r = mid - 1;
            }
            else
            {
                result = mid;
                break;
            }
        }
        return result;   
    }
}
