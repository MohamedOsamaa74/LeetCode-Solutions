class Solution {
public:
    char nextGreatestLetter(vector<char>& letters, char target) {
        int st = 0, en = letters.size()-1, md, ans = 0;
        while(en>=st){
            md = (st+en)/2;
            if(letters[md]>target) ans = md, en = md-1;
            else st = md+1;
        }
        return letters[ans];
    }
};