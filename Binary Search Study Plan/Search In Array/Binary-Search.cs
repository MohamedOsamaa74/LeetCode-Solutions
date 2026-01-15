1public class Solution {
2    public int Search(int[] nums, int target) {
3        int n = nums.Length;
4        int st = 0, en = n-1;
5        int ans = -1;
6        while(st<=en){
7            int md = (st+en)/2;
8            if(nums[md]==target){
9                ans = md;
10                break;
11            }
12            else if(nums[md]>target) en = md-1;
13            else st = md+1;
14        }
15        return ans;
16    }
17}