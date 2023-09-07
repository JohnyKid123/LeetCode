public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        IList<int> result = new List<int>();
        int m = matrix.Length;
        int n = matrix[0].Length;
        int left = 0, right = n - 1, top = 0, bottom = m - 1;
        while (left <= right && top <= bottom) {
            for (int i = left; i <= right; i++) {
                result.Add(matrix[top][i]);
            }
            for (int i = top + 1; i <= bottom; i++) {
                result.Add(matrix[i][right]);
            }
            if (left < right && top < bottom) {
                for (int i = right - 1; i >= left; i--) {
                    result.Add(matrix[bottom][i]);
                }
                for (int i = bottom - 1; i > top; i--) {
                    result.Add(matrix[i][left]);
                }
            }
            left++;
            right--;
            top++;
            bottom--;
        }
        return result;
    }
}
