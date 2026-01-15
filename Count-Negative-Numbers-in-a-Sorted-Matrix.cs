1public class Solution {
2    public int CountNegatives(int[][] grid) {
3        int cnt = 0;
4        for(int i = grid.Length - 1; i >= 0 ;i--){
5            for(int j = grid[i].Length -1; j >= 0; j--){
6                if(grid[i][j] >= 0) break;
7                cnt++;
8            }
9        }
10        return cnt;
11    }
12}