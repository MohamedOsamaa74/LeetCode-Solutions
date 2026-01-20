1public class Solution {
2    public bool IsMonotonic(int[] nums) {
3        bool inc = true, dec = true;;
4        for(int i = 1; i < nums.Length; i++){
5            if(!dec && !inc) return false;
6            if(nums[i]<nums[i-1]) dec = false;
7            else if(nums[i]>nums[i-1]) inc = false;
8        }
9        if(!dec && !inc) return false;
10        return true;
11    }
12
13}