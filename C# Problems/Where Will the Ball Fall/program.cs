public class Solution {
    public int[] FindBall(int[][] grid) {
    int m = grid.Length;
    int n = grid[0].Length;
    int[] answer = new int[n];
    for (int i = 0; i < n; i++) {
        int row = 0, col = i;
        while (row < m) {
            if (grid[row][col] == 1) {
                if (col == n - 1 || grid[row][col + 1] == -1) {
                    answer[i] = -1; 
                    break;
                }
                col++; 
            } else { 
                if (col == 0 || grid[row][col - 1] == 1) {
                    answer[i] = -1; 
                    break;
                }
                col--; 
            }
            row++; 
        }
        if (answer[i] == 0) { 
            answer[i] = col;
        }
    }
    return answer;
}

}
