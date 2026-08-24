public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        if (image[sr][sc] == color) {
            return image;
        }

        Fill(image, sr, sc, image[sr][sc], color);

        return image;
    }

    public void Fill(int[][] image, int sr, int sc, int currColor, int color) {
        if (sr < 0 || sc < 0 || sr >= image.Length || sc >= image[0].Length ||
            image[sr][sc] != currColor) {
            return;
        }
        image[sr][sc] = color;
        Fill(image, sr - 1, sc, currColor, color);
        Fill(image, sr + 1, sc, currColor, color);
        Fill(image, sr, sc - 1, currColor, color);
        Fill(image, sr, sc + 1, currColor, color);
    }
}