// The API isBadVersion is defined for you.
// bool isBadVersion(int version);

class Solution {
public:
    int firstBadVersion(int n) {
        long long st = 1, en = n, md, ans = -1;
        while(en>=st){
            md = (st+en)/2;
            if(isBadVersion(md)) en = md-1, ans = md;
            else st = md+1;
        }
        return ans;
    }
};