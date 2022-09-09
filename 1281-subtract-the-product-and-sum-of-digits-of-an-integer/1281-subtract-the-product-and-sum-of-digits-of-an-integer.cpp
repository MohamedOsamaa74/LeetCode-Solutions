class Solution {
public:
    int subtractProductAndSum(int n) {
        string s = to_string(n);
        long long p = 1, sum = 0;
        for(int i = 0 ; i < s.size() ; i++){
            p*=(s[i]-'0');
            sum+=(s[i]-'0');
        }
        return p - sum;
    }
};