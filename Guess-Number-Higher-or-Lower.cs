1/** 
2 * Forward declaration of guess API.
3 * @param  num   your guess
4 * @return 	     -1 if num is higher than the picked number
5 *			      1 if num is lower than the picked number
6 *               otherwise return 0
7 * int guess(int num);
8 */
9
10public class Solution : GuessGame {
11    public int GuessNumber(int n) {
12        int st = 1, en = n;
13        int md = st+(en-st)/2;
14        while(en>=st){
15            md = st+(en-st)/2;
16            int ans = guess(md);
17            if(ans > 0) st = md + 1;
18            else if(ans < 0) en = md - 1;
19            else return md;
20        }
21        return -1;
22    }
23}