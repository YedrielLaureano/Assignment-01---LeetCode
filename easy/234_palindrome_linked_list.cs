// 234. Palindrome Linked List
// Yedriel Laureano

public class Solution {
    public bool IsPalindrome(ListNode head) {
        List<int> values = new List<int>();

        ListNode current = head;
        while (current != null) {
            values.Add(current.val);
            current = current.next;
        }

        int left = 0;
        int right = values.Count - 1;

        while (left < right) {
            if (values[left] != values[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
}