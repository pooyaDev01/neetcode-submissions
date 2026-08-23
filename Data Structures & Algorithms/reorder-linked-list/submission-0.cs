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

        ListNode slow = head;
        ListNode fast = head.next;

        while (fast != null && fast.next != null) {
            fast = (fast.next).next;
            slow = slow.next;
        }

        ListNode second = slow.next;
        ListNode prev = slow.next = null;

        while (second != null) {
            ListNode temp = second.next;
            second.next = prev!;
            prev = second;
            second = temp;
        }

        ListNode firstChain = head;
        second = prev!;

        while (second != null) {
            ListNode temp1 = firstChain.next;
            ListNode temp2 = second.next;

            firstChain.next = second;
            second.next = temp1;

            firstChain = temp1;
            second = temp2;
        }
    }
}
