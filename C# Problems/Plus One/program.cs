public class Solution {
    public int[] PlusOne(int[] digits) {
    int n = digits.Length;
    
    if (digits[n - 1] < 9) {
        digits[n - 1]++;
        return digits;
    }
    
    int i = n - 1;
    while (i >= 0 && digits[i] == 9) {
        digits[i] = 0;
        i--;
    }
    
    if (i < 0) {
        int[] res = new int[n + 1];
        res[0] = 1;
        return res;
    }
    
    digits[i]++;
    for (int j = i + 1; j < n; j++) {
        digits[j] = 0;
    }
    
    return digits;
}

}
