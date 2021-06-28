using Xunit;
using Taz_LeetCode.Problems;

public class TestLongestCommonPrefix
{
    LongestCommonPrefix sut = new();

    [Fact]
    public void Example1()
    {
        Assert.Equal("fl", sut.Solution(new string[] {"flower","flow","flight"}));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(string.Empty, sut.Solution(new string[] {"dog","racecar","car"}));
    }
}