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
        ListNode prev = new(0, head);
        ListNode current = head;

        while(current != null)
        {
            if(n == 0)
            {
                prev = prev.next;
            }else{
                n--;
            }
            current = current.next;
        }
        if(prev.next == head)
        {
            return head.next;
        }
        else
        {
            prev.next = prev.next.next;
        }
        return head;
    }
}

// 1 2 3 4
// n: 0
// prev: 0 0 1 2
// current: 1 2 3 4

// 5
// n: 1
// prev: 0
// current: 5







