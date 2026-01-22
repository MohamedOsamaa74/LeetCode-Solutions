1public class Solution {
2    public int CountCharacters(string[] words, string chars) {
3        int[] mp = new int[26];
4        foreach(char ch in chars){
5            mp[ch-'a']++;
6        }
7        int ans = 0;
8        foreach(var word in words){
9            int[] freq = new int[26];
10            bool ok = true;
11            foreach(var ch in word){
12                freq[ch-'a']++;
13                if(mp[ch-'a']==0 || (freq[ch-'a'] > mp[ch-'a'])){
14                    ok = false;
15                    break;
16                } 
17            }
18            if(ok) ans+=word.Length;
19        }
20        return ans;
21    }
22}