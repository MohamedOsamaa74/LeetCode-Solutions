1public class Solution {
2    public int HeightChecker(int[] heights) {
3        int[] expected = (int[])heights.Clone();
4        Array.Sort(expected);
5        int ans = 0;
6        for(int i = 0; i < heights.Length; i++){
7            if(heights[i]!=expected[i]) ans++;
8        }
9        return ans;
10    }
11}