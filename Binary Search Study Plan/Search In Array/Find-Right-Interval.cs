1public class Solution {
2    public int[] FindRightInterval(int[][] intervals) {
3        SortedDictionary<int, int> mp = new SortedDictionary<int, int>();
4        for(int i = 0; i < intervals.Length; i++){
5            mp[intervals[i][0]] = i;
6        }
7        int[] ans = new int[intervals.Length];
8        int[] starts = mp.Keys.ToArray();
9        for(int i = 0; i < intervals.Length; i++){
10            int st = 0, en = starts.Length-1, res = -1;
11            while(st<=en){
12                int md = st + (en-st) /2;
13                if(starts[md]>=intervals[i][1]){
14                    res = mp[starts[md]];
15                    en = md-1;
16                }
17                else st = md+1;
18            }
19            ans[i] = res;
20        }
21        return ans;
22    }
23}