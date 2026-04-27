public class Solution {
    public int FindDuplicate(int[] nums) {
        HashSet<int> visited = new HashSet<int>();

        foreach (int num in nums) {
            if (visited.Contains(num))
                return num;

            visited.Add(num);
        }

        return -1;
    }
}
