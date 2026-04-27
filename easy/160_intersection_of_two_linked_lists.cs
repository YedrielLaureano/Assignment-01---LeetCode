// 160. Intersection of Two Linked Lists
// Yedriel Laureano

public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        ListNode a = headA;
        ListNode b = headB;

        while( a != b)
        {
            a = a != null? a.next : headB;
            b = b != null? b.next : headA;
        }

        return a;
    }
}