class Solution {
public:
    int arraySign(vector<int>&v) {
        int cnt = 0;
        for(int i : v){
            if(i==0) return 0;
            if(i<0) cnt++;
        }
        if(cnt%2) return -1;
        else return 1;
    }
};