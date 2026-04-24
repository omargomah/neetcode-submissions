    public class MinStack
    {
        public class Node
        {
            public int Item { get; set; }
            public int Min { get; set; }
            public Node Next { get; set; }
        }
        private Node _top;
        public MinStack()
        {
            _top = null!;
        }
        private bool IsEmpty() => _top is null;

        public void Push(int val)
        {
            Node newNode = new Node()
            {
                Item = val,
                Next = _top,
                Min = _top is null ? val :Math.Min(val, _top.Min)   
            };
            _top = newNode;

        }

        public void Pop()
        {
            if (IsEmpty())
                return;
            _top = _top.Next;
        }

        public int Top()
        {
            if(IsEmpty())
                return -1;
            return _top.Item;
        }

        public int GetMin()
        {
            if(IsEmpty())
                return -1;
            return _top.Min;
        }
    }