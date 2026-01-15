1public class Solution {
2    public int[] TwoSum(int[] nums, int target) {
3        Dictionary<int, int> mp = new Dictionary<int, int>();
4        int[] ans = new int[2];
5        for(int i = 0; i< nums.Length ; i++){
6            int complement = target-nums[i];
7            if(mp.ContainsKey(complement) && mp[complement]!=i){
8                ans[0] = i;
9                ans[1] = mp[complement];
10                return ans;
11            }
12            mp[nums[i]] =  i;
13        }
14        return ans;
15    }
16}