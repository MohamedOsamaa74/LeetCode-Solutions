1public class Solution {
2    public int CountStudents(int[] students, int[] sandwiches) {
3        Queue<int> queue = new();
4        Stack<int> st = new();
5        foreach (int s in students) queue.Enqueue(s);
6        for (int i = sandwiches.Length - 1; i >= 0; i--) st.Push(sandwiches[i]);
7        int rot = 0;
8        while (st.Count>0)
9        {
10            if (queue.Peek() == st.Peek())
11            {
12                queue.Dequeue();
13                st.Pop();
14                rot = 0;
15            }
16            else
17            {
18                queue.Enqueue(queue.Dequeue());
19                rot++;
20            }
21            if(rot == queue.Count) break;
22        }
23        return rot;
24    }
25}