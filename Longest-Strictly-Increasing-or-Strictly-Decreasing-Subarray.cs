1public class Solution {
2    public int LongestMonotonicSubarray(int[] nums) {
3        int inc = 1;
4        int dec = 1;
5        int mx = 1;
6        for(int i = 1; i < nums.Length; i++){
7            if(nums[i]>nums[i-1]){
8                inc++;
9                dec = 1;
10            }
11            else if(nums[i]<nums[i-1]){
12                dec++;
13                inc = 1;
14            }
15            else inc = dec = 1;
16            mx = Math.Max(mx, Math.Max(inc, dec));
17        }
18        return mx;
19    }
20}