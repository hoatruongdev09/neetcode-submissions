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
        if(head.next == null || head.next.next == null)
        {
            return;
        }

        ListNode slow = head;
        ListNode fast = head.next;

        while(fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }
        ListNode lastHalf = slow.next;
        slow.next = null;

        ListNode prev = null;
        ListNode revCurrent = lastHalf;
        while(revCurrent != null)
        {
            ListNode revNext = revCurrent.next;
            revCurrent.next = prev;
            prev = revCurrent;
            revCurrent = revNext;
        }
        lastHalf = prev;

        ListNode result = new();
        ListNode current = result;

        while(head != null && lastHalf != null)
        {
            current.next = head;
            current = current.next;
            head = head.next;

            current.next = lastHalf;
            current = current.next;
            lastHalf = lastHalf.next;
        }
        while(head != null)
        {
            current.next = head;
            head = head.next;
            current = current.next;
        }
        while(lastHalf != null)
        {
            current.next = lastHalf;
            lastHalf = lastHalf.next;
            current = current.next;
        }
        head = result.next;
    }
}
