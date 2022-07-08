class Solution {
public:
    static bool cmp(pair<int, int>a, pair<int, int>b){
        if(a.second==b.second) return a.first < b.first;
        return a.second < b.second;
    }
    vector<int> kWeakestRows(vector<vector<int>>& mat, int k) {
        vector<pair<int, int>>vp;
        for(int i = 0 ; i < mat.size() ; i++){
            int o = 0;
            for(int j = 0 ; j < mat[i].size() ; j++){
                if(mat[i][j]==1) o++;
            }
            vp.push_back({i, o});
        }
        sort(vp.begin(), vp.end(), cmp);
        vector<int>ans;
        for(int i = 0; i < k ; i++) ans.push_back(vp[i].first);
        return ans;
    }
};