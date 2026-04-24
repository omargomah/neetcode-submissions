public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) 
    {
        for (int i = 1; i < position.Length; i++)
        {
            bool flag = true;
            for (int j = 0; j < position.Length-i; j++)
            {
                if (position[j] < position[j+1])
                {
                    int temp = position[j]; position[j] = position[j+1]; position[j+1] = temp;
                    temp = speed[j]; speed[j] = speed[j+1]; speed[j+1] = temp;
                    flag = false;
                }
            }
            if(flag)
                break;
        }
        int counter = 0,l = 0;
        while(l < position.Length)
        {
            double time = (target - position[l]) / (double)speed[l++];
            counter++;
            while (l < position.Length && time >= (target - position[l]) / (double)speed[l])
                l++;
        }
        return counter;    
    }
}
