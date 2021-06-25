using Xunit;
using Taz_LeetCode.Problems;

public class TestReverse
{

    Reverse sut = new Reverse();

    [Fact]
    public void Example4()
    {
        Assert.Equal(0, sut.Solution(0));
    }

    [Fact]
    public void Exapmple2()
    {
        Assert.Equal(-321, sut.Solution(-123));
    }

    [Fact]
    public void Example3()
    {
        Assert.Equal(21, sut.Solution(120));
    }

    [Fact]
    public void Example1()
    {
        Assert.Equal(321, sut.Solution(123));
    }

    [Fact]
    public void BIGBOI()
    {
        //Assert.Equal()
    }
}