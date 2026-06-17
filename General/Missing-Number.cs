1public class Solution {
2    public int MissingNumber(int[] nums) {
3        bool[] arr = new bool[nums.Length+1];
4        foreach(var i in nums)
5        {
6            arr[i] = true;
7        }
8        for(int i = 0; i <= nums.Length; i++)
9        {
10            if(arr[i]==false) return i;
11        }
12        return -1;
13    }
14}