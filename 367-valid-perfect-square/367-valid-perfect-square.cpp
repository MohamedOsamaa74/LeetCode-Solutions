class Solution {
public:
    bool isPerfectSquare(int num) {
        long long st = 1, en = num, md;
        while(en>=st){
            md = (st+en)/2;
            if(md*md==num) return true;
            else if(md*md>num) en = md-1;
            else st = md+1;
        }
        return false;
    }
};