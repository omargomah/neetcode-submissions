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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
                   ListNode result =null! , back= null!;
                int sum ,prev=0;
                while (l1 is not null && l2 is not null)
                {
                    sum = l1.val + l2.val+ prev;
                    ListNode temp = new ListNode(sum%10);
                    if(result is null)
                        result = back = temp;
                    else
                        back.next = temp;
                    back = temp;
                    prev = sum/10;
                    l1 = l1.next;
                    l2 = l2.next;
                }
                while (l1 is not null)
                {
                    sum = l1.val + prev;
                    ListNode temp = new ListNode(sum%10);
                    back.next = temp;
                    back = temp;
                    l1 = l1.next;
                    prev = sum / 10;
                }
                while (l2 is not null)
                {
                    sum = l2.val + prev;
                    ListNode temp = new ListNode(sum%10);
                    back.next = temp;
                    back = temp;
                    l2 = l2.next;
                    prev = sum / 10;
                }
                if (prev==1)
                {
                    ListNode temp = new ListNode(prev);
                    back.next = temp;
                }
                return result;

    }
}
