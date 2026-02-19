1public class Solution {
2    public bool MakeEqual(string[] words) {
3        Dictionary<char, int> freq = new();
4        int sz = 0;
5        foreach(string s in words)
6        {
7            sz+=s.Length;
8            foreach(char c in s){
9                if(!freq.ContainsKey(c)) freq[c] = 1;
10                else freq[c]++;
11            }
12        }
13        if(sz%words.Length!=0) return false;
14        for(char c = 'a'; c <= 'z' ; c++)
15        {
16            if(freq.ContainsKey(c) && freq[c]%words.Length!=0) return false;
17        }
18        return true;
19    }
20}