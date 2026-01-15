public class Solution {
    
    public char NextGreatestLetter(char[] letters, char target) {
        int st = 0, en = letters.Length -1, md = 0;
        char ans = letters[0];
        while(en>=st){
            md = (en+st)/2;
            if(letters[md] > target){
                en = md-1;
                ans = letters[md];
            } 
            else st = md+1;
        }
        return ans;
    }
}
