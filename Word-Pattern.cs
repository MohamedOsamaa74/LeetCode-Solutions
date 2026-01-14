1public class Solution {
2    public bool WordPattern(string pattern, string s) {
3        string[] Words = s.Split(' ');
4        if(pattern.Length != Words.Length) return false;
5        Dictionary<char, string> mp1 = new Dictionary<char, string>();
6        Dictionary<string, char> mp2 = new Dictionary<string, char>();
7        for(int i = 0; i < pattern.Length ; i++){
8            if(mp1.ContainsKey(pattern[i]) && mp1[pattern[i]] != Words[i]) return false;
9            if(mp2.ContainsKey(Words[i]) && mp2[Words[i]] != pattern[i]) return false;
10            mp1[pattern[i]] = Words[i];
11            mp2[Words[i]] = pattern[i];
12        }
13        return true;
14    }
15}