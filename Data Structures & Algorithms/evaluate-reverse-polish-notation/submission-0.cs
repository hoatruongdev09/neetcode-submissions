public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> numbers = new();
        
        foreach(var token in tokens) 
        {
            int n1;
            int n2;
            switch(token)
            {
                case "+":
                n2 = numbers.Pop();
                n1 = numbers.Pop();
                numbers.Push(n1 + n2);
                break;
                case "-":
                n2 = numbers.Pop();
                n1 = numbers.Pop();
                numbers.Push(n1 - n2);
                break;
                case "*":
                n2 = numbers.Pop();
                n1 = numbers.Pop();
                numbers.Push(n1 * n2);
                break;
                case "/":
                n2 = numbers.Pop();
                n1 = numbers.Pop();
                numbers.Push((int)(n1 / n2));
                break;
                default:
                    numbers.Push(Convert.ToInt32(token));
                break;
            }
        }

        return numbers.Peek();
    }
}
