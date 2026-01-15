1public class Solution {
2    public int MaxAscendingSum(int[] nums) {
3        int ans = nums[0], sum = nums[0];
4        for(int i = 1; i < nums.Length ; i++){
5            if(nums[i]>nums[i-1]) sum+=nums[i];
6            else{
7                ans = Math.Max(ans, sum);
8                sum = nums[i];
9            }
10        }
11        ans = Math.Max(ans, sum);
12        return ans;
13    }
14}