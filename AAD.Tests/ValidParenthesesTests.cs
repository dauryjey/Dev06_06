using System.Collections;

namespace AAD.Tests;

public class ValidParenthesesTests
{
    [Theory]
    [InlineData("", true)]
    [InlineData("()", true)]
    [InlineData("{}", true)]
    [InlineData("[]", true)]
    [InlineData("(())", true)]
    [InlineData("()()", true)]
    [InlineData("(((1))(x))", true)]
    [InlineData("{([1])(x)}", true)]
    [InlineData("(", false)]
    [InlineData(")", false)]
    [InlineData("(})", false)]
    [InlineData("}()", false)]
    public void Tests(string s, bool expected)
    {
        var actual = ValidParentheses(s);
        Assert.Equal(expected, actual);
    }

    private bool ValidParentheses(string s)
    {
        var pairs = new Dictionary<char, char>
        {
            { '(', ')'},
            { '{', '}'},
            { '[', ']'}
        };
        
        var stack = new Stack<char>();
        
        foreach (var chr in s)
        {
            if (pairs.TryGetValue(chr, out var pairEnd))
            {
                stack.Push(pairEnd);
                continue;
            }

            if (pairs.ContainsValue(chr))
            {
                if (stack.Count == 0)
                    return false;
                
                var last = stack.Pop();
                if (last != chr)
                    return false;
            }
        }

        return stack.Count == 0;
    }
}