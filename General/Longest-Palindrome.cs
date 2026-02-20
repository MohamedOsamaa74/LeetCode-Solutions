1public class Solution {
2    public int LongestPalindrome(string s) {
3        Dictionary<char, int> freq = new();
4        foreach(char c in s)
5        {
6            if(!freq.ContainsKey(c)) freq[c] = 1;
7            else freq[c]++;
8        }
9        bool ok = false;
10        int len = s.Length, ans = 0, rem = 0;;
11        foreach(var pair in freq){
12            if(pair.Value>1){
13                if(pair.Value%2==0) ans+=pair.Value;
14                else{
15                    ans+=pair.Value-1;
16                    rem++;
17                }
18            }
19            else if(pair.Value==1) rem++;
20        }
21        if(rem>0) ans++;
22        return ans;
23    }
24}