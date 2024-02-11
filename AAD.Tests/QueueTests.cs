using System.Collections;

namespace AAD.Tests;

public class QueueTests
{
    [Fact]
    public void QueueAndDequeue()
    {
        var q = new Queue<int>();
        
        q.Enqueue(1);
        
        Assert.Equal(1, q.Dequeue());
    }
    
    [Fact]
    public void Dequeue_Empty()
    {
        var q = new Queue<int>();

        Assert.Throws<InvalidOperationException>(() => q.Dequeue());
    }
    
    [Fact]
    public void Peek()
    {
        var q = new Queue<int>();

        q.Enqueue(1);
        
        var peek = q.Peek();
        
        Assert.Equal(1, peek);

        var dequeued = q.Dequeue();
        
        Assert.Equal(1, dequeued);
    }
}