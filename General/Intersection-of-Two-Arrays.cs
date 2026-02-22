1public class Solution {
2    public int[] Intersection(int[] nums1, int[] nums2) {
3        HashSet<int> set = new(nums1);
4        HashSet<int> ans = new();
5        foreach(int x in nums2){
6            if(nums1.Contains(x)) ans.Add(x);
7        }
8        return ans.ToArray();
9    }
10}