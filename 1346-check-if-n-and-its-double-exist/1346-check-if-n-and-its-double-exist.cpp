class Solution {
public:
    bool checkIfExist(vector<int>& arr) {
        sort(arr.begin(), arr.end());
        for(int i = 0 ; i < arr.size() ; i++){
            int st = 0, en = arr.size()-1, md;
            //if(arr[i]>=0) int st = 0, en = i-1, md;
            //else int st = i+1, en = 0, md;
            while(st<=en){
                md = (en+st)/2;
                if(arr[i]==arr[md]*2 and i!=md) return true;
                else if(arr[md]*2>arr[i]) en = md-1;
                else st = md+1;
            }
        }
        return false;
    }
};