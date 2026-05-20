public class MinStack {
    private Stack<int> main;
    private Stack<int> sub;

    public MinStack() {
        main = new();
        sub = new();    
    }
    
    public void Push(int val) {
        main.Push(val);
        Stack<int> temp = new();
        while(sub.Count > 0 && val > sub.Peek()) {
            temp.Push(sub.Pop());
        }
        sub.Push(val);
        while(temp.Count > 0) {
            sub.Push(temp.Pop());
        }
    }
    
    public void Pop() {
        var val = main.Pop();
        Stack<int> temp = new();
        while(sub.Count > 0 && sub.Peek() != val) {
            temp.Push(sub.Pop());
        }
        sub.Pop();
        while(temp.Count > 0) {
            sub.Push(temp.Pop());
        }
    }
    
    public int Top() {
        return main.Peek();
    }
    
    public int GetMin() {
        return sub.Peek();
    }
}
