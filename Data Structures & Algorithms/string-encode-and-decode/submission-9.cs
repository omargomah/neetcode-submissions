public class Solution {

public  string Encode(IList<string> strs) =>   strs.Count == 0 ? null : string.Join('-', strs);

public  List<string> Decode(string s) => s is null ? [] : [.. s.Split('-')];

}
