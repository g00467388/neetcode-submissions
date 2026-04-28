public class MinStack {
    private List<int> _backingList = new(); 
    
    public MinStack() {
        
    }
    
    public void Push(int val) {
        _backingList.Add(val);
    }
    
    public void Pop() {
        _backingList.RemoveAt(_backingList.Count - 1);
    }
    
    public int Top() {
        return _backingList.ElementAt(_backingList.Count - 1);
    }

    public int GetMin()
    {
        int? lowest = _backingList[0];
        if (lowest == null)
            return -1;
        for (int i = 0; i < _backingList.Count; i++)
        {
            if (lowest > _backingList[i])
                lowest = _backingList[i];
        }
        return (int)lowest; 
    }
}