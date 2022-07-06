class Solution {
public:
    int specialArray(vector<int>& nums) {
        sort(nums.begin(), nums.end());
        int n = *max_element(nums.begin(), nums.end());
        for(int i = 1 ; i <= n ; i++){
            auto it = lower_bound(nums.begin(), nums.end(), i);
            if(nums.size()-(it-nums.begin())==i) return i;
        }
        return -1;
    }
};