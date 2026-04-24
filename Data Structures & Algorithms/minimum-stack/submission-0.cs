    public class stackNode
    {
        int item;
        stackNode next;
        public stackNode()
        {
            item = 0;
            next = null;
        }
        public int Item { get => item; set => item = value; }
        public stackNode Next { get => next; set => next = value; }
    }


    public class MinStack
    {
        stackNode tail;
        public MinStack() => tail = null;

        public void Push(int val)
        {
            if (tail == null)
               tail = new stackNode() { Item = val};
            else
            {
                stackNode temp = new stackNode() { Item = val};
                temp.Next = tail;
                tail = temp;
            }
        }

        public void Pop() => tail = tail.Next;

        public int Top() => tail.Item;

        public int GetMin()
        {
            int min = int.MaxValue;
            stackNode temp = tail;
            while (temp != null)
            {
                if(temp.Item < min)
                    min = temp.Item;
                temp = temp.Next;
            }
            return min;
        }
    }
