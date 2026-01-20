1public class Solution {
2    public bool Check(int[] nums) {
3        int cnt = 0;
4        for(int i = 1; i < nums.Length; i++){
5            if(nums[i]<nums[i-1]) cnt++;
6        }
7        if(nums[0]<nums[nums.Length-1]) cnt++;
8        return cnt<=1;
9    }
10}