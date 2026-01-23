1public class Solution {
2    public bool IsPathCrossing(string path) {
3        HashSet<(int,int)>Paths = new();
4        (int x, int y) cur = (0,0);
5        Paths.Add(cur);
6        foreach(char c in path){
7            if(c=='N') cur.y++;
8            else if(c=='S') cur.y--;
9            else if(c=='W') cur.x--;
10            else cur.x++;
11            int n = Paths.Count;
12            Paths.Add(cur);
13            if(n==Paths.Count) return true;
14        }
15        return false;
16    }
17}