1public class Solution {
2    public int RemoveElement(int[] nums, int val) {
3        if(nums.Length==0) return 0;
4        int j = nums.Length-1;
5        for(int i = 0; i < nums.Length; i++){
6            while(nums[j]==val && j > i) j--;
7            if(j<=i) break;
8            if(nums[i]==val){
9                nums[i] = nums[j];
10                nums[j] = val;
11                j--;
12            }
13        }
14        return nums[j] == val ? j : j+1;
15    }
16}