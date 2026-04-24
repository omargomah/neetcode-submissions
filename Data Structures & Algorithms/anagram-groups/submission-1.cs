public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
                        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
                foreach (var item in strs)
                {
                    string orderstring = new(item.Order().ToArray());
                    if (dict.ContainsKey(orderstring))
                        dict[orderstring].Add(item);
                    else 
                        dict[orderstring] = [item];
                }
                return dict.Select(x=> x.Value).ToList();

    }
}
