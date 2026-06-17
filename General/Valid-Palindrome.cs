1public class Solution {
2    public bool IsPalindrome(string s) {
3        int left = 0, right = s.Length-1;
4        while(left<right)
5        {
6            if(!char.IsLetterOrDigit(s[left])) left++;
7            else if(!char.IsLetterOrDigit(s[right])) right--;
8            else{
9                if(char.ToLower(s[left]) != char.ToLower(s[right])) return false;
10                left++; right--;
11            }
12        }
13        return true;
14    }
15}