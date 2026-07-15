
 
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode curr=head;
        ListNode prev=null;
        ListNode future=null;
        while(curr!=null)
        {
            future=curr.next;
            curr.next=prev;
            prev = curr;
            curr=future;
        }
        return prev;
    }
}
