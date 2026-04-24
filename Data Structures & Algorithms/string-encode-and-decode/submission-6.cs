public class Solution {

    public string Encode(IList<string> strs) 
    {
            if (strs.Count != 0)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < strs.Count; i++)
                {
                    sb.Append($"{strs[i]}");
                    if (i != strs.Count - 1)
                        sb.Append('~');
                }
                return sb.ToString();
            }
            else
                return null;
    }

    public List<string> Decode(string s)
    {
            if (s is null)
                return new List<string>();
            else if (s == "")
                return new List<string>() { "" };
            else
                return s.Split('~').ToList();
    }
}
