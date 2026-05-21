public class Node {
    public int key;
    public int val;
    public Node next;
    public Node(int key, int val, Node next) {
        this.key = key;
        this.val = val;
        this.next = next;
    }
}
public class MyHashMap {

    private Node[] map;

    public MyHashMap() {
        map = new Node[1000];
        for(int i = 0; i < map.Length; i++)
        {
            map[i] = new(-1, -1, null);
        }
    }

    private int Hash(int key)
    {
        return key % map.Length;
    }
    
    public void Put(int key, int value) {
        int h = Hash(key);
        var c = map[h].next;
        var prev = map[h];
        while(c != null)
        {
            if(c.key == key){
                c.val = value;
                return;
            }
            prev = c;
            c = c.next;
        }
        prev.next = new(key,value, null);
    }
    
    public int Get(int key) {
        int h = Hash(key);
        var c = map[h].next;
        while(c != null)
        {
            if(c.key == key)
            {
                return c.val;
            }
            c = c.next;
        }
        return -1;
    }
    
    public void Remove(int key) {
        int h = Hash(key);
        var c = map[h].next;
        var prev = map[h];
        while(c != null)
        {
            if(c.key == key)
            {
                prev.next = c.next;
                return;
            }
            prev = c;
            c = c.next;
        }
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */


//  ["MyHashMap","put","put","get","get","put","get","remove","get"]
//  [.   [],     [1,1],[2,2], [1],  [3],  [2,1],[2],   [2],    [2]]











