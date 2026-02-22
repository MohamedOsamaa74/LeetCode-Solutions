1public class Solution {
2    public int[] Intersection(int[] nums1, int[] nums2) {
3        HashSet<int> ans = new();
4        Array.Sort(nums2);
5        foreach(int x in nums1){
6            if(BS(x, nums2)) ans.Add(x);
7        }
8        return ans.ToArray();
9    }
10    private static bool BS(int target, int[] nums)
11    {
12        int st = 0, en = nums.Length - 1;
13        while(st<=en){
14            int md = st + (en-st)/2;
15            if(nums[md]==target) return true;
16            else if(nums[md]>target) en = md - 1;
17            else st = md + 1;
18        }
19        return false;
20    }
21}