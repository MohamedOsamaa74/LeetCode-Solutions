1public class Solution {
2    public bool CanPlaceFlowers(int[] flowerbed, int n) {
3        int m = flowerbed.Length;
4
5        for (int i = 0; i < m; i++) {
6            if (flowerbed[i] == 0) {
7                bool leftEmpty = (i == 0) || flowerbed[i - 1] == 0;
8                bool rightEmpty = (i == m - 1) || flowerbed[i + 1] == 0;
9
10                if (leftEmpty && rightEmpty) {
11                    flowerbed[i] = 1;
12                    n--;
13                    if (n == 0) return true;
14                }
15            }
16        }
17        return n <= 0;
18    }
19}