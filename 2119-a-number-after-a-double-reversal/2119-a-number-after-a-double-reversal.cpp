class Solution {
public:
    bool isSameAfterReversals(int n) {
        bool ok = 0;
        while(n%10==0 && n!=0){
            n/=10;
            ok = 1;
        }
        if(!ok) return true;
        if(n!=0 && !ok) return true;
        return false;
    }
};