class Solution {
public:
    static bool cmp(vector<int>&a, vector<int>&b){
        if(a[0]==b[0]) return a[1]<b[1];
        return a[0]>b[0];
    }
    int numberOfWeakCharacters(vector<vector<int>>& vv) {
        int ans = 0;
        sort(vv.begin(), vv.end(), cmp);
        int mx = INT_MIN;
        for(auto it : vv){
            ans+=(mx > it[1]);
            mx = max(mx, it[1]);
        }
        return ans;
    }
};