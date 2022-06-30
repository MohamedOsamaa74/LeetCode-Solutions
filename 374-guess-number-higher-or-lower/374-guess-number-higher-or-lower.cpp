/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

class Solution {
public:
    int guessNumber(int n) {
        long long st = 1, en = n, md;
        while(en>=st){
            md = (st+en)/2;
            if(guess(md)<0) en = md-1;
            else if(guess(md)>0) st = md+1;
            else return md;
        }
        return -1;
    }
};