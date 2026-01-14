1public class MyHashMap {
2    private int[] data;
3    public MyHashMap() {
4        data = new int[1000001];
5        Array.Fill(data, -1);
6    }
7    
8    public void Put(int key, int value) {
9        data[key] = value;
10    }
11    
12    public int Get(int key) {
13        return data[key];
14    }
15    
16    public void Remove(int key) {
17        data[key] = -1;
18    }
19}
20
21/**
22 * Your MyHashMap object will be instantiated and called as such:
23 * MyHashMap obj = new MyHashMap();
24 * obj.Put(key,value);
25 * int param_2 = obj.Get(key);
26 * obj.Remove(key);
27 */