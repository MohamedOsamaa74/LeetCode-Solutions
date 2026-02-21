1public class Solution {
2    public int FirstUniqChar(string s) {
3        int[] freq = new int[26];
4        foreach(char c in s) freq[c-'a']++;
5        for(int i = 0; i < s.Length; i++){
6            if(freq[s[i]-'a']==1) return i;
7        }
8        return -1;
9    }
10}