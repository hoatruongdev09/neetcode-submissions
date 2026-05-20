public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var pairs = position.Select((p, index) => (p, speed[index])).OrderBy((pairs => -pairs.p)).ToList();
        float[] times = pairs.Select(p => (float)(target - p.p) / p.Item2).ToArray();

        Stack<float> stack = new();

        for (int i = 0; i < times.Length; i++)
        {
            stack.Push(times[i]);
            if (stack.Count >= 2)
            {
                float current = stack.Pop();
                float prev = stack.Peek();
                if (current > prev)
                {
                    stack.Push(times[i]);
                }
            }
        }

        return stack.Count;
    }
}
