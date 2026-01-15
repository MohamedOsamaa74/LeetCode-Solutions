1public class Solution {
2    public int SearchInsert(int[] nums, int target) {
3        int st = 0, en = nums.Length-1, md = 0;
4        while(en>=st){
5            md = (st+en)/2;
6            if(nums[md]==target) return md;
7            else if(nums[md]>target) en = md-1;
8            else if(nums[md]<target) st = md+1;
9        }
10        return en+1;
11    }
12}