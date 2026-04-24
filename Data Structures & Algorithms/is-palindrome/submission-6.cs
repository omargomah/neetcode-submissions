public class Solution {
    public bool IsPalindrome(string s) {
                        int l = 0, r = s.Length - 1;
                s = s.ToLower();
                while (l < r) 
                {
                    while (!char.IsLetterOrDigit(s[l]))
                    {
                        l++;
                        if (l >= r)
                            break;
                    }
                    while (!char.IsLetterOrDigit(s[r]))
                    {
                        r--;
                        if (l >= r)
                            break;
                    }
                    if (l >= r)
                        break;
                    if ( s[l] != s[r])
                        return false;
                    l++;
                    r--;
                }
                return true;
    }
}
