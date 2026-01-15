1public class Solution {
2    public string KthDistinct(string[] arr, int k) {
3        Dictionary<string, int> freq = new Dictionary<string, int>();
4        foreach(string s in arr){
5            if(freq.ContainsKey(s)) freq[s]++;
6            else freq[s] = 1;
7        }
8        foreach(string s in arr){
9            if(freq[s]==1) k--;
10            if(k==0) return s;
11        }
12        return "";
13    }
14}