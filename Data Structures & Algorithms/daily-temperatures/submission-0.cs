public class Solution {
    public int[] DailyTemperatures(int[] temperatures) 
    {
            int[] arr = new int[temperatures.Length];
        int l = 0 , r = 1  ,  counter = 1;
        while(l != temperatures.Length-1)
        {
            if (temperatures[r] <= temperatures[l])
            {
                counter++;
                if(r == temperatures.Length - 1)
                {
                    arr[l] = 0;
                    counter = 1;
                    r = ++l;
                }
            }
            else
            {
                arr[l] = counter;
                counter = 1;
                r = ++l ;
            }
            r++;
        }
        return arr;    
    }
}
