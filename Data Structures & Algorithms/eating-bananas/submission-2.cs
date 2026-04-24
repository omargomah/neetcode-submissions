public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {

                int start = 1 ,max = 0  ,mid ,result = int.MaxValue ,hours;
                for (int i = 0; i < piles.Length; i++)
                {
                    if (piles[i] > max)
                        max = piles[i];
                }
                while (start <= max)
                {
                    hours = 0;
                    mid =(start+max) / 2;
                    foreach (var item in piles)
                    {
                        hours += (int)Math.Ceiling(item / (double)mid);
                    }
                    if (hours > h)
                        start = mid+1;
                    else if (hours <= h)
                    {
                        if(mid < result)
                            result = mid;
                        max = mid-1;
                    }
                }
                return result;

    }
}
