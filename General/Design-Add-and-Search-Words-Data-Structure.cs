1public class WordDictionary {
2    List<string> words;
3    public WordDictionary() {
4        words = new();
5    }
6    
7    public void AddWord(string word) {
8        words.Add(word);
9    }
10    
11    public bool Search(string word) {
12        foreach(string s in words){
13            if(s.Length!=word.Length) continue;
14            bool ok = true;
15            for(int i = 0; i < s.Length; i++){
16                if(word[i]=='.') continue;
17                if(s[i]!=word[i]){
18                    ok = false;
19                    break;
20                }
21            }
22            if(ok) return true;
23        }
24        return false;
25    }
26}
27
28/**
29 * Your WordDictionary object will be instantiated and called as such:
30 * WordDictionary obj = new WordDictionary();
31 * obj.AddWord(word);
32 * bool param_2 = obj.Search(word);
33 */