class Solution {
public:
    vector<int> searchRange(vector<int>& nums, int target) {
        int st = 0, en = nums.size()-1, md, ans1 = -1, ans2 = -1;
        while(en>=st){
            md = st+(en-st)/2;
            if(nums[md]==target) ans1 = md, en = md-1;
            else if(nums[md] < target) st = md+1;
            else en = md-1;
        }
        st = 0, en = nums.size()-1, md, ans2 = -1;
        while(en>=st){
            md = st+(en-st)/2;
            if(nums[md]==target) ans2 = md, st = md+1;
            else if(nums[md] < target) st = md+1;
            else en = md-1;
        }
        return {ans1, ans2};
    }
};