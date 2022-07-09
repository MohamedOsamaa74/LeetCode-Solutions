class Solution {
public:
    bool judgeSquareSum(int c) {
        long long st = 0, en = sqrt(c), md;
        while(en>=st){
            md = en*en + st*st;
            if(md==c) return true;
            else if(md > c) en--;
            else st++;
        }
        return false;
    }
};