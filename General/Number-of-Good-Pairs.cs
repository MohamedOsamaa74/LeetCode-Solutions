1public class Solution {
2    public int NumIdenticalPairs(int[] nums) {
3        int ans = 0;
4        for(int i = 0; i < nums.Length; i++){
5            for(int j = i+1; j < nums.Length; j++){
6                if(nums[i]==nums[j]) ans++;
7            }
8        }
9        return ans;
10    }
11}