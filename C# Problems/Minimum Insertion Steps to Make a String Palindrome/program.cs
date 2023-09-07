public class Solution {
    public int MinInsertions(string s) {
        int n = s.Length;
        int[,] dp = new int[n, n];
        for (int len = 2; len <= n; len++) {
            for (int i = 0; i <= n - len; i++) {
                int j = i + len - 1;
                if (s[i] == s[j]) {
                    dp[i, j] = dp[i + 1, j - 1];
                } else {
                    dp[i, j] = 1 + Math.Min(dp[i + 1, j], dp[i, j - 1]);
                }
            }
        }
        return dp[0, n - 1];
    }
}
