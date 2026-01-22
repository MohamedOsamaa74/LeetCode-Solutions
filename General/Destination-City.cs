1public class Solution {
2    public string DestCity(IList<IList<string>> paths) {
3        Dictionary<string, string> mp = new();
4        string ans = "";
5        foreach(var path in paths){
6            mp[path[0]] = path[1];
7        }
8        foreach(var path in paths){
9            if(!mp.ContainsKey(path[1])) ans = path[1];
10        }
11        return ans;
12    }
13}