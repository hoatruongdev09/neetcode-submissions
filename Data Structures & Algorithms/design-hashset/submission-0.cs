public class MyHashSet {
    private List<int> l;

    public MyHashSet() {
        l = new();
    }
    
    public void Add(int key) {
        if(l.Contains(key)){return;}
        l.Add(key);
    }
    
    public void Remove(int key) {
        l.Remove(key);
    }
    
    public bool Contains(int key) {
        return l.Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */