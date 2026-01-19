1public class Solution {
2    public bool IsArraySpecial(int[] nums) {
3        for(int i = 1; i < nums.Length; i++){
4            if((nums[i]%2==0 && nums[i-1]%2==0) || (nums[i]%2!=0 && nums[i-1]%2!=0))
5                return false;
6        }
7        return true;
8    }
9}