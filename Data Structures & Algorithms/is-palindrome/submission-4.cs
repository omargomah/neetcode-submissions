public class Solution {
    public bool IsPalindrome(string s) 
    {
            List<char> arr = new List<char>();
        for (int i = 0; i < s.Length; i++)
        {
            char x = char.ToLower(s[i]);
            if ((x > 96 && x < 123) || (x > 47 && x < 58))
                arr.Add(x);
        }
        foreach (var item in arr)
        {
            Console.Write(item);
        }
        int l = 0, r = arr.Count - 1;
        while(l<r)
        {
            if(arr[l] != arr[r])
                return false;
            l++; r--;
        }
        return true;    
    }
}
