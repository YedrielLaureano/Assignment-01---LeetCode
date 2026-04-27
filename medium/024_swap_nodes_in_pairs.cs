// 24. Swap Nodes in Pairs
// Yedriel Laureano

public class Solution {
    public ListNode SwapPairs(ListNode head) {
        if (head == null || head.next == null)
            return head;

        ListNode first = head;
        ListNode second = head.next;

        first.next = SwapPairs(second.next);
        second.next = first;

        return second;
    }
}
