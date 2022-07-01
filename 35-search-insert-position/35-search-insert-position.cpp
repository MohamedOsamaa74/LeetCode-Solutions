class Solution {
public:
    int searchInsert(vector<int>& nums, int target) {
        int st = 0, en = nums.size()-1, md;
        while(en>=st){
            md=st+en >>1;
            if(nums[md]==target) return md;
            else if(nums[md]>target) en = md-1;
            else st = md+1;
        }
        return en+1;
    }
};