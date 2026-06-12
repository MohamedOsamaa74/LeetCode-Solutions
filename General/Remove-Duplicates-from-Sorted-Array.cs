1public class Solution {
2    public int RemoveDuplicates(int[] nums) {
3        if(nums.Length == 0) return 0;
4        int j = 0;
5        for(int i = 1; i < nums.Length; i++)
6        {
7            if(nums[i] != nums[j]){
8                nums[++j] = nums[i];
9            }
10        }
11        return j+1;
12    }
13}