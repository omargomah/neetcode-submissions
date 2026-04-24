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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
                ListNode head = null;
                ListNode back =  null;
                ListNode temp =  null;
                while(true)
                {
                    if (list1 is null && list2 is null)
                    {
                        return head;
                    }
                    if ( list1 is not null && (list2 is null || list1.val < list2.val ))
                    {
                        temp = new ListNode(list1.val);
                        if (back is null)
                        {
                            back = head = temp;
                        }
                        else 
                        {
                            back.next = temp;
                            back = temp;
                        }
                        list1 = list1.next;
                    }
                    else
                    {
                        temp = new ListNode(list2!.val);
                        if (back is null)
                        {
                            back = head = temp;
                        }
                        else
                        { 
                            back.next = temp;
                            back = temp;
                        }
                        list2 = list2.next;
                    }
                }   
    }
}