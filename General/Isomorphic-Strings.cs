1public class Solution {
2    public bool IsIsomorphic(string s, string t) {
3        Dictionary<char, char> mp = new();
4        for(int i = 0; i < s.Length; i++)
5        {
6            if(mp.ContainsKey(s[i]) && mp[s[i]] != t[i]) return false;
7            if(!mp.ContainsKey(s[i]) && mp.ContainsValue(t[i])) return false;
8            mp[s[i]] = t[i];
9        }
10        return true;
11    }
12}