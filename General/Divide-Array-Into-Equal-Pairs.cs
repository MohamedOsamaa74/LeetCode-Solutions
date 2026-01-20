1public class Solution {
2    public bool DivideArray(int[] nums) {
3        Dictionary<int, int>mp = new Dictionary<int, int>();
4        foreach(var i in nums){
5            if(!mp.ContainsKey(i)) mp[i] = 1;
6            else mp[i]++;
7        }
8        foreach(var i in nums){
9            if(mp[i]%2 != 0) return false;
10        }
11        return true;
12    }
13}