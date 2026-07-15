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
        ListNode slow =head;
        ListNode fast = head;
        while(fast!=null && fast.next != null)
        {
            slow=slow.next;
            fast=fast.next.next;
        }
        //1 2 ,3 ,4 
        //    s
        ListNode second = slow.next;
        slow.next = null;
        //reverse the secode list;
        ListNode prev=null;
        ListNode curr=second;
       
        while(curr!=null)
        {
            ListNode next=curr.next;
            curr.next=prev;
            prev=curr;
            curr = next;
        }
        ListNode l1=head;
        ListNode l2=prev;
        
        
        while(l2!=null)
        {
            ListNode temp1=l1.next;
            ListNode temp2= l2.next;
            l1.next=l2;
            l2.next=temp1;
            l1=temp1;
            l2=temp2;
        }
    }
}
