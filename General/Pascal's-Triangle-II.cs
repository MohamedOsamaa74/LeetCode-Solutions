1public class Solution {
2    public IList<int> GetRow(int rowIndex) {
3        List<List<int>> triangle = new();
4        for(int row = 0; row <= rowIndex; row++){
5            List<int>cur = new();
6            for(int i = 0; i <= row; i++){
7                if(i==0 || row==0) cur.Add(1);
8                else if(i==row) cur.Add(1);
9                else cur.Add(triangle[row-1][i-1]+triangle[row-1][i]);
10            }
11            triangle.Add(cur);
12        }
13        return triangle[rowIndex];
14    }
15}