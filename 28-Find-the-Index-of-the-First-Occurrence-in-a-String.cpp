class Solution {
public:
    int strStr(string haystack, string needle) {
        int j = needle.length();
        for(int i = 0;  i < haystack.length() ; i++){
            if(i+j > haystack.length()) break;
            if(haystack.substr(i,j) == (needle)){
                return i;
            }
        }
        return -1;
    }
};