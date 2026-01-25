1/* The isBadVersion API is defined in the parent class VersionControl.
2      bool IsBadVersion(int version); */
3
4public class Solution : VersionControl {
5    public int FirstBadVersion(int n) {
6        int st = 1, en = n;
7        int md = 1, ans = -1;
8        while(en >= st){
9            md = st + (en - st) /2;;
10            if(IsBadVersion(md) == true){
11                ans = md;
12                en = md-1;
13            }
14            else st = md+1;
15        }
16        return ans;
17    }
18}