class Solution {
public:
    int arrangeCoins(int n) {
        long long st = 1, en = n, md;
        int ans = 0;
        while(en>=st){
            md = (st+en)/2;
            if(md*(md+1)/2<=n) ans = md, st = md+1;
            else en = md-1;
        }
        return ans;
    }
};