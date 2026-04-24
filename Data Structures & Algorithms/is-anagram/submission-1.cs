public class Solution {
    public bool IsAnagram(string s, string t) 
    {
int[] arr = new int[26];
for (int i = 0; i < s.Length; i++)
    arr[s[i] - 97]++;
for (int i = 0; i < t.Length; i++)
    arr[t[i] - 97]--;
for (int i = 0; i < arr.Length; i++)
    if (arr[i]!= 0)
        return false;
return true;
    }
}
