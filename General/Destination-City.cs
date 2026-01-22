1public class Solution {
2    public string DestCity(IList<IList<string>> paths) {
3        HashSet<string> st = new();
4        string ans = "";
5        foreach(var path in paths){
6            st.Add(path[0]);
7        }
8        foreach(var path in paths){
9            if(!st.Contains(path[1])) ans = path[1];
10        }
11        return ans;
12    }
13}