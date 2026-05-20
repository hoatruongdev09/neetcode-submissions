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
        HashSet<ListNode> travelled = new();
        ListNode current = head;

        while(current != null)
        {
            if(travelled.Contains(current))
            {
                return true;
            }
            travelled.Add(current);
            current = current.next;
        }
        return false;
    }
}
