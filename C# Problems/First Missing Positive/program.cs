public class Solution {
    public int FirstMissingPositive(int[] nums) {
    int n = nums.Length;
    int i = 0;
    while (i < n) {
        if (nums[i] > 0) {
            int j = nums[i] - 1;
            if (j < n && nums[j] != nums[i]) {
                Swap(nums, i, j);
            }
            else {
                i++;
            }
        }
        else {
            i++;
        }
    }
    for (i = 0; i < n; i++) {
        if (nums[i] != i + 1) {
            return i + 1;
        }
    }
    return n + 1;
}

private void Swap(int[] nums, int i, int j) 
{
    int temp = nums[i];
    nums[i] = nums[j];
    nums[j] = temp;
}

}
