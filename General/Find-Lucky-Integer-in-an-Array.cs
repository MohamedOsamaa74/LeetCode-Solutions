1public class Solution {
2    public int FindLucky(int[] arr) {
3        Dictionary<int, int> mp = new Dictionary<int, int>();
4        foreach(var item in arr){
5            if (mp.ContainsKey(item))
6                mp[item]++;
7            else
8                mp[item] = 1;
9        }
10        int lucky = -1;
11        foreach(var item in arr){
12            if(mp[item] == item) lucky = Math.Max(lucky, item);
13        }
14        return lucky;
15    }
16}