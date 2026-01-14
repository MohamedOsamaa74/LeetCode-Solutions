1public class MyHashSet {
2    private List<int> data;
3    public MyHashSet() {
4        data = new List<int>();
5    }
6    
7    public void Add(int key) {
8        if(!data.Contains(key)) data.Add(key);
9    }
10    
11    public void Remove(int key) {
12        if(data.Contains(key)) data.Remove(key);
13    }
14    
15    public bool Contains(int key) {
16        return data.Contains(key);
17    }
18}
19
20/**
21 * Your MyHashSet object will be instantiated and called as such:
22 * MyHashSet obj = new MyHashSet();
23 * obj.Add(key);
24 * obj.Remove(key);
25 * bool param_3 = obj.Contains(key);
26 */