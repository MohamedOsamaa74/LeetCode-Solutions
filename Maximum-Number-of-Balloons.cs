1public class Solution {
2    public int MaxNumberOfBalloons(string text) {
3        Dictionary<char, int>mp = new Dictionary<char, int>{
4            {'b', 0}, {'a', 0}, {'l', 0}, {'o', 0}, {'n', 0}
5        };
6        foreach(char c in text){
7            if(mp.ContainsKey(c)) mp[c]++;
8            else mp[c] = 1;
9        }
10        return Math.Min(mp['b'],
11               Math.Min(mp['a'],
12               Math.Min(mp['n'],
13               Math.Min(mp['l']/2, mp['o']/2))));
14    }
15}