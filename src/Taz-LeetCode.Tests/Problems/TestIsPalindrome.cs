using Xunit;
using Taz_LeetCode.Problems;

public class TestIsPalindrome
{
    IsPalindrome sut = new IsPalindrome();

    [Fact]
    public void Example1()
    {
        Assert.True(sut.Solution(121));
    }

    [Fact]
    public void Example2()
    {
        // Negatives are always not a balidrome
        Assert.False(sut.Solution(-121));
    }

    [Fact]
    public void Example3()
    {
        Assert.False(sut.Solution(10));
    }

    [Fact]
    public void Example4()
    {
        Assert.False(sut.Solution(-101));
    }
}