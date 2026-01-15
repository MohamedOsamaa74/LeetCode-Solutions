1public class Solution {
2    public int MinOperations(int[] nums, int k) {
3        int sum = 0;
4        foreach(int num in nums) sum+=num;
5        return sum%k;
6    }
7}