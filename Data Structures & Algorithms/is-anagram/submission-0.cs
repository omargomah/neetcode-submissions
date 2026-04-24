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
}
