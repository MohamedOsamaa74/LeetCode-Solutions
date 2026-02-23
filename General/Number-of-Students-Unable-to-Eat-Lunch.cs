1public class Solution {
2    public int CountStudents(int[] students, int[] sandwiches) {
3        Queue<int> queue = new();
4        Stack<int> st = new();
5        for (int i = sandwiches.Length - 1; i >= 0; i--){
6            st.Push(sandwiches[i]);
7            queue.Enqueue(students[i]);
8        }
9        int rot = 0;
10        while (st.Count>0)
11        {
12            if (queue.Peek() == st.Peek())
13            {
14                queue.Dequeue();
15                st.Pop();
16                rot = 0;
17            }
18            else
19            {
20                queue.Enqueue(queue.Dequeue());
21                rot++;
22            }
23            if(rot == queue.Count) break;
24        }
25        return rot;
26    }
27}