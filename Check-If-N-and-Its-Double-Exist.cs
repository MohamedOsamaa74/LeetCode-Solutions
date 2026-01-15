1public class Solution {
2    public bool CheckIfExist(int[] arr) {
3        HashSet<int> set = new HashSet<int>();
4        foreach(int num in arr){
5            if(set.Contains(num*2) || (num%2==0 && set.Contains(num/2))) return true;
6            set.Add(num);
7        }
8        return false;
9    }
10}