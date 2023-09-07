public class Solution {
   public string Multiply(string num1, string num2) {
    int m = num1.Length, n = num2.Length;
    int[] res = new int[m + n];
    
    for (int i = m - 1; i >= 0; i--) {
        for (int j = n - 1; j >= 0; j--) {
            int p1 = i + j, p2 = i + j + 1;
            int mul = (num1[i] - '0') * (num2[j] - '0');
            int sum = mul + res[p2];
            res[p2] = sum % 10;
            res[p1] += sum / 10;
        }
    }
    
    StringBuilder sb = new StringBuilder();
    foreach (int num in res) {
        if (num == 0 && sb.Length == 0) continue;
        sb.Append(num);
    }
    
    return sb.Length == 0 ? "0" : sb.ToString();
}

}
