class Solution {
public:
    static bool cmp(vector<int>&a, vector<int>&b){
        if(a[0]==b[0]) return a[1] < b[1];
        return a[0] > b[0];
    }
    int numberOfWeakCharacters(vector<vector<int>>& properties)     {
        sort(properties.begin(), properties.end(), cmp);
        int mx = INT_MIN;
        int ans = 0;
        for(auto it : properties){
            ans += (mx > it[1]);
            mx = max(mx, it[1]);
        }
        return ans;
    }
};