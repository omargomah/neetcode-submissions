   public class MinStack
   {
       public class Node
       {
           public int Item { get; set; }
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
               Next = _top
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
           Node temp = _top;
           int min = int.MaxValue;
           while (temp is not null)
           {
               if(min > temp.Item)
                   min = temp.Item;
               temp = temp.Next;
           }
           return min;
       }
   }

