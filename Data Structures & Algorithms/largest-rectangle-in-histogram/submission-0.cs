public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<(int index, int height)> stack = new();
        int max = 0;
        for(int i = 0; i < heights.Length; i++)
        {
            int h = heights[i];
            int startIndex = i;
            while(stack.Count > 0 && stack.Peek().height > h)
            {
                (int index, int height) = stack.Pop();
                max = Math.Max(max, height * (i - index));
                startIndex = index;
            }
            stack.Push((startIndex, h));
        }

        while(stack.Count > 0)
        {
            (int index, int height) = stack.Pop();
            max = Math.Max(max, height * (heights.Length - index));
        }
        return max;
    }
}
