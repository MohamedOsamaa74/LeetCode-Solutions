1public class Solution {
2    public int CountStudents(int[] students, int[] sandwiches) {
3        int sq = 0, c = 0;
4        foreach(int i in students){
5            if(i==0) c++;
6            else sq++;
7        }
8        foreach(int i in sandwiches){
9            if(i==0)
10            {
11                if(c==0) return sq;
12                else c--;
13            } 
14            else
15            {
16                if(sq==0) return c;
17                else sq--;
18            }
19        }
20        return 0;
21    }
22}