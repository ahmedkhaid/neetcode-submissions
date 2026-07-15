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
    public ListNode MergeTwoList(ListNode node1, ListNode node2)
    {
        ListNode dummy = new ListNode(0);
        ListNode p1 =node1;
        ListNode p2 = node2;
        ListNode temp = dummy;
        while(p1!=null && p2!=null)
        {
            if(p1.val<p2.val)
            {
                temp.next = p1;
                p1=p1.next;
            }
            else{
                temp.next = p2;
                p2=p2.next;
            }
            temp = temp.next;
            
        }
        if(p1 == null)
        {
            temp.next = p2;
        }
        else{
            temp.next = p1;
        }
        return dummy.next;
    }
    public ListNode MergeRange(ListNode[]lists,int start,int end)
    {
        if(start==end)
            return lists[start];
        if(start>end)
            return null;
        int mid = (start+end)/2;
        ListNode left = MergeRange(lists,start,mid);
        ListNode right = MergeRange(lists,mid+1,end);
        return MergeTwoList(left,right);
    }    
    public ListNode MergeKLists(ListNode[] lists) {
      if(lists.Length==0 || lists==null)
        return null;
       return MergeRange(lists,0,lists.Length-1);
    }
}
