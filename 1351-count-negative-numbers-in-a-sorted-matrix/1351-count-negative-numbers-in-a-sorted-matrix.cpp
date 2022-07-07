class Solution {
public:
    int countNegatives(vector<vector<int>>& grid) {
        int ans = 0;
        for(int i = 0 ; i < grid.size() ; i++){
            auto it = upper_bound(grid[i].rbegin(), grid[i].rend(), -1);
            ans+=(it-grid[i].rbegin());
        }
        return ans;
    }
};