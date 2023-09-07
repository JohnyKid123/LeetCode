public class Solution {
    public bool IsMonotonic(int[] nums) {
        bool increasing = true;
        bool decreasing = true;
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] < nums[i - 1]) {
                increasing = false;
            }
            if (nums[i] > nums[i - 1]) {
                decreasing = false;
            }
        }
        return increasing || decreasing;
    }
}
