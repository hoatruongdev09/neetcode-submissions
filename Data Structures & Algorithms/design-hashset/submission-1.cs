public class Node {
    public int val;
    public Node next;
}
public class MyHashSet {
    private Node root;

    public MyHashSet() {
        root = new Node();    
    }
    
    public void Add(int key) {
        var c = root.next;
        while(c != null)
        {
            if(c.val == key)
            {
                return;
            }
            c = c.next;
        }
        c = root.next;
        var node = new Node();
        node.val = key;
        node.next = root.next;
        root.next = node;
    }
    
    public void Remove(int key) {
        var prev = root;
        var c = root.next;
        while(c != null)
        {
            if(c.val == key){
                prev.next = c.next;
                break;
            }
            prev = c;
            c = c.next;
        }
    }
    
    public bool Contains(int key) {
        var c = root.next;
        while(c != null)
        {
            if(c.val == key)
            {
                return true;
            }
            c = c.next;
        }
        return false;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */