class Solution {
public:
    int maxDistance(vector<int>& nums1, vector<int>& nums2) {
        int ans = 0;
        for(int i = 0 ; i < nums1.size() ; i++){
            int st = i, en = nums2.size()-1, md;
            while(en>=st){
                md=(en+st)/2;
                if(nums2[md]>=nums1[i]) ans = max(ans, md-i), st=md+1;
                else en=md-1;
            }
        }
        return ans;
    }
};