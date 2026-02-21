1public class Solution {
2    public int MaxLengthBetweenEqualCharacters(string s) {
3        Dictionary<char, int> mp = new();
4        int ans = -1;
5        for(int i = 0; i < s.Length; i++){
6            if(!mp.ContainsKey(s[i])){
7                mp[s[i]] = i;
8            }
9            else{
10                ans = Math.Max(ans, i-mp[s[i]]-1);
11            }
12        }
13        return ans;
14    }
15}