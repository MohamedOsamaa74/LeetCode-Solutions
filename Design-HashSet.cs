1public class MyHashSet {
2    private bool[] data;
3    public MyHashSet() {
4        data = new bool[1000001];
5    }
6    
7    public void Add(int key) {
8        data[key] = true;
9    }
10    
11    public void Remove(int key) {
12        data[key] = false;
13    }
14    
15    public bool Contains(int key) {
16        return data[key];
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