1public class Solution {
2    public int PivotIndex(int[] nums) {
3        int n = nums.Length;
4        int sum = 0, leftSum = 0;
5        for(int i = 0; i < n; i++){
6            sum+=nums[i];
7        }
8        for(int i = 0; i < n; i++){
9            leftSum+=nums[i];
10            if(sum-leftSum == leftSum-nums[i]) return i;
11        }
12        return -1;
13    }
14}