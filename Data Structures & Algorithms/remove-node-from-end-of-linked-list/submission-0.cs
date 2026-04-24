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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
                ListNode x = head , y = head;
                int temp = n;
                while (y != null &&n!=-1)
                {
                    y = y.next;
                    n--;
                }
                if (y is  null && n!=-1 )
                    return head.next;
                while (y is not null)
                {
                    y = y.next;
                    x = x.next;
                }
                x.next = x.next.next;
                return head;

    }
}
