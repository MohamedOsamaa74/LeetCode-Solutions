1public class Solution {
2    public int MissingNumber(int[] nums) {
3        int n = nums.Length;
4        int expectedSum = n * (n + 1) / 2;
5        int sum = 0;
6        foreach(var i in nums) sum+=i;
7        return expectedSum-sum;
8    }
9}