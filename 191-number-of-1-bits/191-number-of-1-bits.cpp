class Solution {
public:
    int hammingWeight(uint32_t n) {
        string s = bitset<32>(n).to_string();
        return count(s.begin(), s.end(), '1');
    }
};