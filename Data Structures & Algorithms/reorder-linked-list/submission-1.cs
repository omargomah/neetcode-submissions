/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public void ReorderList(ListNode head) {
                        List<ListNode> listNodes = new List<ListNode>();
                while (head is not null)
                {
                    listNodes.Add(head);
                    head = head.next;
                }
                int length = listNodes.Count , l =  0, r = listNodes.Count-1;
                while (l < r)
                {
                    listNodes[l++].next = listNodes[r];
                    listNodes[r--].next = listNodes[l];
                }
                listNodes[l].next = null!;
                head = listNodes[0];

    }
}
