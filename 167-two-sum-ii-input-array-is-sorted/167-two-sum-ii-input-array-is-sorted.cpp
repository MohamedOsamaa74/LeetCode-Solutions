class Solution {
public:
    vector<int> twoSum(vector<int>& numbers, int target) {
        int ans1, ans2;
        for(int i = 0 ; i < numbers.size() ; i++){
            int st = i, en = numbers.size()-1, md, ans1 = -1, ans2 = -1;
            while(en>=st){
                md = (en+st)/2;
                if(numbers[i]+numbers[md]==target and i!=md) return {i+1, md+1};
                else if(numbers[i]+numbers[md]>target) en = md-1;
                else st = md+1;
            }
        }
        return {ans1, ans2};
    }
};