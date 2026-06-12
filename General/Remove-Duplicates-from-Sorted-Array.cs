1public class Solution {
2    public int RemoveDuplicates(int[] nums) {
3        SortedSet<int> st = new();
4        foreach(int i in nums) st.Add(i);
5        for(int i = 0; i < nums.Length; i++){
6            if(i+1<=st.Count) nums[i] = st.ElementAt(i);
7        }
8        Array.Resize(ref nums, st.Count);
9        return nums.Length;
10    }
11}