public class Solution {
    public double FindMaxAverage(int[] nums, int k) 
    {
                double sum = 0, avg = 0;
        
        for(int i = 0; i < k; i++) sum += nums[i];
        avg = sum / k;
        for(int i = k; i < nums.Length; i++)
        {               
            sum = sum + nums[i] - nums [i - k];
            if(avg < sum / k) avg = sum / k;
        }

        return avg;       
    }
}
