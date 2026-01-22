1public class Solution {
2    public int CountConsistentStrings(string allowed, string[] words) {
3        bool[] exist = new bool[26];
4        foreach(char ch in allowed) exist[ch-'a'] = true;
5        int ans = 0;
6        foreach(string word in words){
7            bool ok = true;
8            foreach(char c in word){
9                if(exist[c-'a']==false){
10                    ok = false;
11                    break;
12                }
13            }
14            if(ok) ans++;
15        }
16        return ans;
17    }
18}