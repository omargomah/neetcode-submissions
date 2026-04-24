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
            public  Node copyRandomList(Node head)
            {
                if(head is null)
                return null;
                                Node temp = head;
                Dictionary<Node, Node> dict = new Dictionary<Node, Node>();
                while (temp is not null)
                {
                    Node newNode = new Node(temp.val);
                    dict[temp] = newNode;
                    temp = temp.next;
                }
                temp = head; 
                while (temp is not null)
                {
                    if(temp.next is not null)
                        dict[temp].next = dict[temp.next];
                    if(temp.random is not null)
                        dict[temp].random = dict[temp.random];
                    temp = temp.next;
                }
                return  dict[head];

            }
}
