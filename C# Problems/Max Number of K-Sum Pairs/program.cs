public class Solution {
    public int MaxOperations(int[] nums, int k) 
    {
              int count = 0;
        int left = 0;
        int right = nums.Length - 1;
        Array.Sort(nums);
        while (left < right)
        {
            int sum = nums[left] + nums[right];
            if (sum < k)
            {
                left++;
            }

            if (sum > k)
            {
                right--;
            }

            if (sum == k)
            {
                count++;
                right--;
                left++;
            }
            
        }

        return count;  
    }
}
