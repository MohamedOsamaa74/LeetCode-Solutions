1public class Solution {
2    public int MaxProductDifference(int[] nums) {
3        int mx1 = 0, mx2 = 0, mn1 = 100005, mn2 = 100005;
4        foreach(int x in nums){
5            if(x > mx1){
6                mx2 = mx1;
7                mx1 = x;
8            }
9            else if(x > mx2){
10                mx2 = x;
11            }
12            if(x < mn1){
13                mn2 = mn1;
14                mn1 = x;
15            }
16            else if(x < mn2){
17                mn2 = x;
18            }
19        }
20        return mx1*mx2 - mn1*mn2;
21    }
22}