1public class Solution {
2    public bool CanConstruct(string ransomNote, string magazine) {
3        int[] mp = new int[26];
4        foreach(char c in magazine) mp[c-'a']++;
5        foreach(char c in ransomNote){
6            if(mp[c-'a']==0) return false;
7            mp[c-'a']--;
8        }
9        return true;
10    }
11}