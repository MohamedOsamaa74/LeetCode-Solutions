1public class Solution {
2    public int MaxScore(string s) {
3        int sum = 0;
4        foreach(char c in s) sum+=(c-'0');
5        int l = 0, ans = 0;
6        for(int i = 0; i < s.Length; i++){
7            if(s[i]-'0'==0) l++;
8            else sum-=(s[i]-'0');
9            if(i!=s.Length-1) ans = Math.Max(ans, sum+l);
10        }
11        return ans;
12    }
13}