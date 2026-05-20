public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dic = new();
        foreach(int num in nums)
        {
            if(dic.ContainsKey(num))
            {
                dic[num]++;
            }
            else
            {
                dic[num] = 1;
            }
        }

        PriorityQueue<int, int> pq = new();
        foreach(var pair in dic)
        {
            pq.Enqueue(pair.Key, -pair.Value);
        } 
        int[] result = new int[k];
        for(int i = 0; i < k; i++)
        {
            result[i] = pq.Dequeue();
        }

        return result;
    }
}
