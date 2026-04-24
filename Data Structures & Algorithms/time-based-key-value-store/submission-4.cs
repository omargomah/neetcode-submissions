public class TimeMap {
                Dictionary<string, List<(int,string)>> dict;
                public TimeMap()
                {
                    dict = new Dictionary<string, List<(int, string)>>();
                }

                public void Set(string key, string value, int timestamp)
                {
                    if(!dict.ContainsKey(key))
                        dict[key] = new List<(int, string)>();
                    dict[key].Add((timestamp,value));
                }

                public string Get(string key, int timestamp)
                {
                    if (!dict.ContainsKey(key))
                        return "";
                    List<(int ,string)> res = dict[key];
                    int l = 0 , r = res.Count-1 ,mid , x = int.MinValue;
                    string y = "";
                    while (l <= r)
                    {
                        mid = (l + r) / 1;
                        if (res[mid].Item1 == timestamp)
                            return res[mid].Item2;
                        else if (res[mid].Item1 > timestamp)
                            r = mid - 1;
                        else
                        { 
                            l = mid + 1;
                            if (res[mid].Item1 > x)
                                y = res[mid].Item2;
                        }
                        
                    }
                    return y;
                }

}
