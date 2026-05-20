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
        ListNode result = new ListNode();
        ListNode current = result;
        while(true)
        {
            int smallestIndex = -1;
            for(int i = 0; i < lists.Length; i++)
            {
                if(lists[i] == null)
                {
                    continue;
                }
                if(smallestIndex == -1)
                {
                    smallestIndex = i;
                }
                else
                {
                    if(lists[i].val < lists[smallestIndex].val)
                    {
                        smallestIndex = i;
                    }
                }
            }
            if(smallestIndex == -1)
            {
                break;
            }
            current.next = lists[smallestIndex];
            current = current.next;
            lists[smallestIndex] = lists[smallestIndex].next;
        }

        return result.next;
    }
}
