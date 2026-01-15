1public class Solution {
2    public int[] SearchRange(int[] nums, int target) {
3        int[] ans = {-1,-1};
4        ans[0] = LowerBound(nums, target);
5        ans[1] = UpperBound(nums, target);
6        return ans;
7    }
8    public int LowerBound(int[] nums, int target){
9        int st = 0, en = nums.Length-1;
10        int md = (st+en)/2, ans = -1;
11        while(st<=en){
12            md = (st+en)/2;
13            if(nums[md]==target){
14                ans = md;
15                en = md-1;
16            }
17            else if(nums[md] > target) en = md-1;
18            else st = md+1;
19        }
20        return ans;
21    }
22
23    public int UpperBound(int[] nums, int target){
24        int st = 0, en = nums.Length-1;
25        int md = (st+en)/2, ans = -1;
26        while(st<=en){
27            md = (st+en)/2;
28            if(nums[md]==target){
29                ans = md;
30                st = md+1;
31            }
32            else if(nums[md] > target) en = md-1;
33            else st = md+1;
34        }
35        return ans;
36    }
37}