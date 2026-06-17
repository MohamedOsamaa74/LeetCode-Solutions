1public class Solution {
2    public bool ContainsDuplicate(int[] nums) {
3        HashSet<int> st = new();
4        foreach(var i in nums)
5        {
6            int n = st.Count;
7            st.Add(i);
8            if(st.Count == n) return true;
9        }
10        return false;
11    }
12}