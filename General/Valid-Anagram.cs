1public class Solution {
2    public bool IsAnagram(string s, string t) {
3        if(s.Length != t.Length) return false;
4        int[] freq = new int[26];
5        for(int i = 0; i < s.Length; i++)
6        {
7            freq[s[i]-'a']++;
8            freq[t[i]-'a']--;
9        }
10        foreach(int i in freq){
11            if(i!=0) return false;
12        }
13        return true;
14    }
15}