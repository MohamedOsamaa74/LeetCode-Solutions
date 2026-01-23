1public class Solution {
2    public int MaxProductDifference(int[] nums) {
3        Array.Sort(nums);
4        int n = nums.Length;
5        return (nums[n-1]*nums[n-2]) - (nums[0]*nums[1]);
6    }
7}