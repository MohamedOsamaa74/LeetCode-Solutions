1public class Solution {
2    public string LargestGoodInteger(string num) {
3        int mx = -1;
4        string ans = "";
5        for(int i = 1 ; i < num.Length-1 ; i++){
6            if(num[i]==num[i-1] && num[i]==num[i+1]){
7                if((num[i]-'0') > mx){
8                    mx = (num[i]-'0');
9                    ans = num.Substring(i-1, 3);
10                }
11            }
12        }
13        return ans;
14    }
15}