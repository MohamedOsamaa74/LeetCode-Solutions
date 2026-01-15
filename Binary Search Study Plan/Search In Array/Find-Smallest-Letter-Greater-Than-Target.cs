1public class Solution {
2    
3    public char NextGreatestLetter(char[] letters, char target) {
4        int st = 0, en = letters.Length -1, md = 0;
5        char ans = letters[0];
6        while(en>=st){
7            md = (en+st)/2;
8            if(letters[md] > target){
9                en = md-1;
10                ans = letters[md];
11            } 
12            else st = md+1;
13        }
14        return ans;
15    }
16}