using System.Collections;

namespace AAD.Tests;

public class StackTests
{
    [Fact]
    public void Pop()
    {
        var stack = new Stack<string>();
        
        stack.Push("A");
        stack.Push("B");
        
        Assert.Equal("B", stack.Pop());
    }
    
    [Fact]
    public void Pop_Empty()
    {
        var stack = new Stack<string>();

        Assert.Throws<InvalidOperationException>(() => stack.Pop());
    }

    [Fact]
    public void Peek()
    {
        var stack = new Stack<int>();
        stack.Push(1);
        
        var result = stack.Peek();
        
        Assert.Equal(result, 1);
    }
    
    [Fact]
    public void Peek_Empty()
    {
        var stack = new Stack<int>();
        
        Assert.Throws<InvalidOperationException>(() => stack.Peek());
    }
}