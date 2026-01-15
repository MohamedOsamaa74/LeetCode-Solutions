1public class Solution {
2    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
3        Dictionary<int, int> map = new Dictionary<int, int>();
4        Stack<int>st = new Stack<int>();
5        foreach(int x in nums2){
6            while(st.Count > 0 && st.Peek() < x){
7                map[st.Peek()] = x;
8                st.Pop();
9            }
10            st.Push(x);
11        }
12        int[] ans = new int[nums1.Length];
13        for(int i = 0; i < nums1.Length; i++){
14            if(map.ContainsKey(nums1[i])) ans[i] = map[nums1[i]];
15            else ans[i] = -1;
16        }
17        return ans;
18    }
19}