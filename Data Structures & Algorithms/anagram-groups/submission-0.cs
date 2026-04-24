public class Solution {
        public bool IsAnagram(string s, string t)
{
    if (s.Length == t.Length)
    {
        char[] temp1 = s.ToCharArray() , temp2= t.ToCharArray();
        Array.Sort(temp1);
        Array.Sort(temp2);
        for (int i = 0;i < temp1.Length;i++)
            if (temp1[i] != temp2[i])
                return false;
        return true;
    }
    else
        return false;
}
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
     
            SortedList<int,List<string>> arr = new SortedList<int, List<string>>();
            List <List<string>> solution = new List<List<string>>();
            for (int i = 0 ;i < strs.Length;i++)
            {
                if(arr.ContainsKey(strs[i].Length))
                  arr[strs[i].Length].Add(strs[i]);
                else
                  arr.Add(strs[i].Length , new(){strs[i]});
            }
            int start = 0 , index , end = 1 ;
            foreach (var item in arr)
            {
                solution.Add(new List<string> { item.Value[0] });
                for(int i = 1 ; i < item.Value.Count ; i++ )
                {
                    bool flag = true;
                    index = start;
                    while(index < end)
                    {
                        if(IsAnagram(item.Value[i], solution[index][0]))
                        {
                            solution[index].Add(item.Value[i]);
                            flag = false;
                            break;
                        }
                        index++;
                    }
                    if(flag)
                    {
                        solution.Add(new List<string> { item.Value[i] });
                        end++;
                    }
                }
                start = end++;
            }
            return solution;   
    }
}
