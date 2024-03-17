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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode ans = new ListNode();
        ListNode tail = ans;
        while(l1 is not null && l2 is not null)
        {
            if(l1.val<=l2.val)
            {
                tail.next = l1;
                l1 = l1.next;
            }
            else
            {
                tail.next = l2;
                l2 = l2.next;
            }
                tail = tail.next;
        }
        tail.next = (l1 != null) ? l1 : l2;
        return ans.next;
    }
}
