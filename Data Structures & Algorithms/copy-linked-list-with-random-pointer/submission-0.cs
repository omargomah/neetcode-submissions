/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
            public  int GetIndexOfRandom(Node r ,Node x)
            {
                int count = 0;
                while (r != null) 
                {
                    if (r == x)
                        return count;
                    count++;
                    r = r.next;
                }
                return -1;
            }
            public  Node copyRandomList(Node head)
            {
                Node newHead = null!,back = null!,temp = head ,x;
                List<int> indexes = new List<int>();
                while (temp != null) 
                {
                    Node newNode = new Node(temp.val);
                    if (newHead is null)
                        newHead = back = newNode;
                    else
                    {
                        back.next = newNode;
                        back = newNode;
                    }
                    indexes.Add(GetIndexOfRandom(head,temp.random));
                    temp = temp.next;
                }
                temp = newHead; int i = 0;
                while (temp is not null)
                {
                    x = newHead;
                    if (indexes[i] == -1)
                        temp.random = null!;
                    else
                    {
                        for (int j = 0; j < indexes[i];j++)
                            x = x.next;
                        temp.random = x;
                    }
                    temp = temp.next;
                    i++;
                }
                return newHead;
            }

}
