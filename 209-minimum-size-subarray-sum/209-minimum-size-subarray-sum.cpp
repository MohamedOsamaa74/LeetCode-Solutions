class Solution {
public:
    int minSubArrayLen(int target, vector<int>& nums) {
        int st = 0, en = 0, ans = INT_MAX;
        long long cnt = 0;
        bool ok = 0;
        while(en < nums.size()){
            cnt+=nums[en++];
            while(cnt>=target){
                ans=min(ans, en-st);
                cnt-=nums[st++];
            }
        }
        return ans==INT_MAX ? 0 : ans;
    }
};