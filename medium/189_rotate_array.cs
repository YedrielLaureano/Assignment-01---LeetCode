// 189. Rotate Array
// Yedriel Laureano

public class Solution {
    public void Rotate(int[] nums, int k) {
           int n = nums.Length;
        k %= n;

        int[] rotated = new int[n];

        for (int i = 0; i < n; i++) {
            int newPos = i + k;

            if (newPos >= n)
                newPos -= n;

            rotated[newPos] = nums[i];
        }

        for (int i = 0; i < n; i++) {
            nums[i] = rotated[i];
        }
    }
}