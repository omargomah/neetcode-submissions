    public class DynamicArray
    {
        private int[] StaticArray { get; set; }
        private int Top { get; set; }
        public DynamicArray(int capacity)
        {
            StaticArray = new int[capacity];
            Top = -1;
        }

        public int Get(int i)
        {
            return StaticArray[i];

        }

        public void Set(int i, int n)
        {
            if(i >= StaticArray.Length)
                Resize();
            StaticArray[i] =  n;
        }

        public void PushBack(int n)
        {
            Set(++Top, n);
        }

        public int PopBack()
        {
            var lastElement = Get(Top);
            Set(Top--, 0);
            return lastElement;
        }

        private void Resize()
        {
            var newArray = new int[StaticArray.Length * 2];
            for (int i = 0; i < StaticArray.Length; i++)
                newArray[i] = Get(i);
            StaticArray = newArray;
        }

        public int GetSize()
        {
            for (int i = StaticArray.Length - 1; i >= 0 ; i--)
            {
                if (Get(i) != 0)
                    return i+1;
            }
            return 0;
        }

        public int GetCapacity() => StaticArray.Length;
    }
