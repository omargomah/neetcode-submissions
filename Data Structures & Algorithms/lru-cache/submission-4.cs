    public class DoubleNode
    {
        public int val;
        public int key;
        public DoubleNode next;
        public DoubleNode prev;
        public DoubleNode(int val = 0, int key = 0, DoubleNode next = null, DoubleNode prev = null)
        {
            this.val = val;
            this.key = key;
            this.next = next;
            this.prev = prev;
        }
    }
    public class LRUCache
    {
        Dictionary<int,DoubleNode> Dict;
        DoubleNode head,back;
        int cap , count;
        public LRUCache(int capacity)
        {
            Dict = new Dictionary<int, DoubleNode>(capacity);
            head = back = null;
            cap = capacity;
            count = 0;
        }

        public int Get(int key)
        {
            if (Dict.ContainsKey(key) )
            {
                Track(key);
                return Dict[key].val ;
            }
            return -1;
        }
        private void Track(int key)
        {
            if (count > 1)
            {
                DoubleNode temp = Dict[key];
                if (temp == head)
                {
                    head = head.next;
                    head.prev = null;
                    temp.next = null;
                    back.next = temp;
                    temp.prev = back;
                    back = temp;
                }
                else if (temp != back)
                {
                    temp.prev.next = temp.next;
                    temp.next.prev = temp.prev;
                    temp.prev = back;
                    back.next = temp;
                    temp.next = null;
                    back = temp;
                }
            }
        }
        public void Put(int key, int value)
        {
            if (Dict.ContainsKey(key))
            {
                Dict[key].val = value;
                Track(key);
            }
            else 
            {
                DoubleNode node = new DoubleNode(value,key);
                if (count == cap)
                {
                    Dict.Remove(head.key);
                    if (count == 1)
                        back = head = null;
                    else
                    {
                        head = head.next;
                        head.prev = null;
                    }
                    count--;
                }
                if (back is null )
                    back = head = node;
                else
                {
                    back.next = node;
                    node.prev = back;
                    back = node;
                }
                Dict[key] = node;
                count++;
            }
        }
    }