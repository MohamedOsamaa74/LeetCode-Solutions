1public class Solution {
2    public bool IsCircularSentence(string sentence) {
3        string[] words = sentence.Split(' ');
4        int sz = words.Length;
5        for(int i = 0; i < sz-1; i++){
6            int n = words[i].Length;
7            if(words[i][n-1]!=words[i+1][0]) return false;
8        }
9        if(words[sz-1][words[sz-1].Length-1]!=words[0][0]) return false;
10        return true;
11    }
12}