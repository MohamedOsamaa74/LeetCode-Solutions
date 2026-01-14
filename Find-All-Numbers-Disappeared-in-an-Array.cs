1public class Solution {
2    public List<int> FindDisappearedNumbers(int[] nums) {
3        Dictionary<int, bool> mp = new Dictionary<int, bool>();
4        foreach(int x in nums){
5            mp[x] = true;
6        }
7        List<int> ans = new List<int>();
8        for(int i = 1; i <= nums.Length; i++){
9            if(!mp.ContainsKey(i)) ans.Add(i);
10        }
11        return ans;
12    }
13}