class Solution {
public:
    int findTheDistanceValue(vector<int>& arr1, vector<int>& arr2, int d) {
        sort(arr1.begin(), arr1.end());
        sort(arr2.begin(), arr2.end());
        int ans = 0;
        for(int i = 0 ; i < arr1.size() ; i++){
            auto l = lower_bound(arr2.begin(), arr2.end(), arr1[i]-d);
            auto r = upper_bound(arr2.begin(), arr2.end(), arr1[i]+d);
            if(l==r) ans++;
        }
        return ans;
    }
};