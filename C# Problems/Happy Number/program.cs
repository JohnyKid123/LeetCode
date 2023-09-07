public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> set = new HashSet<int>();
        while(n != 1){
            int sum = 0;
            while(n > 0){
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }
            if(set.Contains(sum)){
                return false;
            }
            set.Add(sum);
            n = sum;
        }
        return true;
    }
}
