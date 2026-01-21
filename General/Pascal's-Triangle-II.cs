1public class Solution {
2    public IList<int> GetRow(int rowIndex) {
3        List<int> ans = new(){1};
4        for(int row = 1; row <= rowIndex; row++){
5            ans.Add(1);
6            for(int i = row-1; i > 0; i--){
7                ans[i] = ans[i-1] + ans[i];
8            }
9        }
10        return ans;
11    }
12}