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
    public ListNode MergeKLists(ListNode[] lists) {
 
                ListNode head = null ,back = null;
                int j = 0, index=0;
                while (true)
                {
                    j = 0;
                    for (int i = 0; i < lists.Length; i++)
                    {
                        if (lists[i] == null)
                        {
                            j++;
                            continue;
                        }
                        else
                        {
                            index = i;
                            break;
                        }
                        
                    }
                    if (j == lists.Length)
                        break;
                    for (int i = j+1; i < lists.Length ; i++)
                    {
                        if (lists[i] == null)
                            continue;
                        if (lists[index].val > lists[i].val)
                            index = i;
                    }
                    if (head is null)
                    {
                        head = back =lists[index];
                        lists[index] = head.next;
                        head.next = null;
                    }
                    else
                    {
                        back.next = lists[index];
                        back = back.next;
                        lists[index] = lists[index].next;
                        back.next = null;
                    }
                }
                return head;
    }
}
