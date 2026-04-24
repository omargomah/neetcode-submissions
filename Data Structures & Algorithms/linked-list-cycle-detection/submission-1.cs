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
    public bool HasCycle(ListNode head) {
                        ListNode? slow = head , fast = head?.next?? null;
                while (fast != null)
                {
                    if (slow == fast)
                        return true;
                    fast = fast?.next?.next ?? null;
                    slow = slow.next;
                }
                return false;

    }
}
