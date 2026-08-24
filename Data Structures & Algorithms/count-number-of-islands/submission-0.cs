public class Solution {
    public int NumIslands(char[][] grid) {
        int row = grid.Length;
        int col = grid[0].Length;

        int count = 0;

        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                if (grid[i][j] == '1') {
                    DFS(grid, i, j);

                    count++;
                }
            }
        }

        return count;
    }

    public void DFS(char[][] grid, int r, int c) {
        if (r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length || grid[r][c] != '1') {
            return;
        }

        grid[r][c] = '0';
        DFS(grid, r - 1, c);
        DFS(grid, r + 1, c);
        DFS(grid, r, c - 1);
        DFS(grid, r, c + 1);
    }
}
