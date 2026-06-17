1public class Solution {
2    public int SingleNumber(int[] nums) {
3        Dictionary<int, int> freq = new();
4        foreach(var i in nums)
5        {
6            if(freq.ContainsKey(i)) freq[i] = 2;
7            else freq[i] = 1;
8        }
9        foreach(var pair in freq)
10        {
11            if(pair.Value==1) return pair.Key;
12        }
13        return -1;
14    }
15}