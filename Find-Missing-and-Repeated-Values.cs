1public class Solution {
2    public int[] FindMissingAndRepeatedValues(int[][] grid) {
3        int n = grid[0].Length;
4        int[] ans = new int[2];
5        Dictionary<int, int>mp = new Dictionary<int, int>();
6        for(int i = 0; i < n; i++){
7            for(int j = 0; j < n; j++){
8                if(mp.ContainsKey(grid[i][j])) mp[grid[i][j]]++;
9                else mp[grid[i][j]] = 1;
10            }
11        }
12        int a = -1, b = -1;
13        for(int i = 1; i <= n*n; i++){
14            if(a!=-1 && b!=-1) break;
15            if(!mp.ContainsKey(i)) b = i;
16            else if(mp[i]==2) a = i;
17        }
18        ans[0] = a; ans[1] = b;
19        return ans;
20    }
21}