1public class Solution {
2    public int MinOperations(string s) {
3        int ans1 = 0, ans2 = 0;
4        for(int i = 0; i < s.Length; i++){
5            char pat1 = (i%2==0) ? '0' : '1';
6            char pat2 = (i%2==1) ? '0' : '1';
7            if(pat1!=s[i]) ans1++;
8            if(pat2!=s[i]) ans2++;
9        }
10        return Math.Min(ans1, ans2);
11    }
12}