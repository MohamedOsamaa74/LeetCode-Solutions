class Solution {
public:
    int findKthPositive(vector<int>& arr, int k) {
        int st = 0, en = arr.size(), md;
        while(en>st){
            md = (en+st)/2;
            if(arr[md]-1-md < k) st = md+1;
            else en = md;
        }
        return st+k;
    }
};