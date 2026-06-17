1public class Solution {
2    public bool ContainsDuplicate(int[] nums) {
3        return new HashSet<int>(nums).Count < nums.Length;
4    }
5}