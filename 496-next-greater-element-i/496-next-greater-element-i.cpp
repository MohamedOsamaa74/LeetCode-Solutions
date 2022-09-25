class Solution {
public:
    vector<int> nextGreaterElement(vector<int>& nums1, vector<int>& nums2) {
        vector<int>ans;
        for(int i = 0 ; i < nums1.size() ; i++){
            bool ok = 0, flag = 0;
            for(int j = 0 ; j < nums2.size() ; j++){
                if(nums2[j]>nums1[i]&&ok){
                    ans.push_back(nums2[j]);
                    flag = 1;
                    break;
                }
                else if(nums2[j]==nums1[i]) ok = 1;
            }
            if(!flag) ans.push_back(-1);
        }
        return ans;
    }
};