1public class Solution {
2    public int[] FindErrorNums(int[] nums) {
3        int[] arr = new int[nums.Length+1];
4        for(int i = 0; i < nums.Length; i++){
5            arr[nums[i]]++;
6        }
7        int[] ans = {-1, -1};
8        for(int i = 1; i <= nums.Length; i++){
9            if(arr[i]==0) ans[1] = i;
10            else if(arr[i]==2) ans[0] = i;
11        }
12        return ans;
13    }
14}