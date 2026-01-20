1public class Solution {
2    public bool Check(int[] nums) {
3        int[] sortedArray = (int[]) nums.Clone();
4        Array.Sort(sortedArray);
5        int x = 0;
6        while(x <= nums.Length){
7            bool ok = true;
8            for(int i = 0; i < nums.Length; i++){
9                if(nums[i]!=sortedArray[(i+x) % nums.Length]){
10                    ok = false;
11                    break;
12                }
13            }
14            if(ok) return true;
15            x++;
16        }
17        return false;
18    }
19}