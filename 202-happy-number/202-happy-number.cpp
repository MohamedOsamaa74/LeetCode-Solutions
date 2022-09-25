class Solution {
public:
    int sqr(int n){
        string s = to_string(n);
        int cnt=0;
        for(int i = 0 ; i < s.size();i++) cnt+=((s[i]-'0')*(s[i]-'0'));
        return cnt;
    }
    bool isHappy(int n) {
        int a, b;
        a = b = n;
        do{
            a=sqr(a);
            b=sqr(sqr(b));
        }
        while(a!=b);
        if(a==1) return 1;
        return 0;
    }
};