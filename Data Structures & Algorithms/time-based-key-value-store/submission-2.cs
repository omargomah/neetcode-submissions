    public class TimeMap
    {
        Dictionary<string, Dictionary<int , string>> timeMap;
        public TimeMap() => timeMap = new Dictionary<string, Dictionary<int, string>>();

        public void Set(string key, string value, int timestamp)
        {
            if(!timeMap.ContainsKey(key))
                timeMap[key] = new Dictionary<int, string>();
            timeMap[key][timestamp] = value;
        }

        public string Get(string key, int timestamp)
        {
            if (!timeMap.ContainsKey(key))
                return "";
            if(timeMap[key].ContainsKey(timestamp))
                return timeMap[key][timestamp];
            int maxValue = int.MinValue;
            string result = "";
            foreach (var item in timeMap[key])
            {
                if(item.Key > maxValue && item.Key < timestamp)
                {
                    maxValue = item.Key;
                    result = item.Value;
                }
            }
            return result;
        }
    }
