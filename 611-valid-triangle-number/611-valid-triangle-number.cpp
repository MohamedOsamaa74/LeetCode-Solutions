class Solution {
public:
    int triangleNumber(vector<int>& nums) {
        sort(nums.begin(), nums.end());
        int ans = 0;
        for(int i = nums.size()-1 ; i >= 0 ; i--){
            int st = 0, en = i-1;
            while(en > st){
                if(nums[en]+nums[st]>nums[i]) ans+=(en-st), en--;
                else st++;
            }
        }
        return ans;
    }
};