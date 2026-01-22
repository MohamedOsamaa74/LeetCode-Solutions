1public class Solution {
2    public int CountCharacters(string[] words, string chars) {
3        Dictionary<char, int> mp = new();
4        foreach(char ch in chars){
5            if(mp.ContainsKey(ch)) mp[ch]++;
6            else mp[ch] = 1;
7        }
8        int ans = 0;
9        foreach(var word in words){
10            Dictionary<char, int> freq = new();
11            bool ok = true;
12            foreach(var ch in word){
13                if(freq.ContainsKey(ch)) freq[ch]++;
14                else freq[ch] = 1;
15                if(!mp.ContainsKey(ch) || (mp.ContainsKey(ch) && freq[ch] > mp[ch])){
16                    ok = false;
17                    break;
18                } 
19            }
20            if(ok) ans+=word.Length;
21        }
22        return ans;
23    }
24}