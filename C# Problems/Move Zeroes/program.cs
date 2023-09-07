public class Solution {
    public void MoveZeroes(int[] nums) 
    {
               if (nums.Length == 0) return;
        int br = 0;
        for (int i = 0; i < nums.Count(); i++)
        {
            if (nums[i] != 0)
            {
                nums[br] = nums[i];
                br++;
            }
        }

        for (int i = br; i < nums.Length; i++)
        {
            nums[i] = 0;
        } 
    }
}
