public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
                        List<(int,int)> list = new List<(int, int)>();
                for (int i = 0; i < position.Length; i++)
                    list.Add((position[i], speed[i]));
                var sortedList = list.OrderBy(x => x.Item1).ToList();
                Stack<double> s = new Stack<double>();
                double time;
                for (int i = sortedList.Count - 1; i > -1; i--)
                {
                    time = (target - sortedList[i].Item1) / (double)sortedList[i].Item2;
                    if (s.Count == 0 || time > s.Peek())
                        s.Push(time);
                }
                return s.Count;

    }
}
