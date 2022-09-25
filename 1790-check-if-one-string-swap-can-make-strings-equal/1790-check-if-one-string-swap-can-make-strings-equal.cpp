class Solution {
public:
    bool areAlmostEqual(string s1, string s2) {
        map<char,int>mp,mpp;
        int cnt = 0;
        for(int i = 0 ; i < s1.size() ; i++){
            mp[s1[i]]++;
            mpp[s2[i]]++;
            if(s1[i]!=s2[i]) cnt++;
        }
        for(char ch = 'a' ; ch <'z' ; ch++){
            if(mp[ch]!=mpp[ch]) return 0;
        }
        if(cnt<=2) return 1;
        return 0;
    }
};