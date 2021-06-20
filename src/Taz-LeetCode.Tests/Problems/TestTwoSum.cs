using Xunit;
using Taz_LeetCode.Problems;

public class TestTwoSum
{
    [Fact]
    public void Example1()
    {
        //Given
        TwoSum sut = new TwoSum();
        //When
        var result = sut.Solution(new int[] {2,7,11,15}, 9);
        //Then
        Assert.Equal(0, result[0]);
        Assert.Equal(1, result[1]);
    }

    [Fact]
    public void Example2()
    {
        //Given
        TwoSum sut = new TwoSum();
        //When
        var result = sut.Solution(new int[] {3,2,4}, 6);
        //Then
        Assert.Equal(1, result[0]);
        Assert.Equal(2, result[1]);
    }

    [Fact]
    public void Example3()
    {
        //Given
        TwoSum sut = new TwoSum();
        //When
        var result = sut.Solution(new int[] {3,3}, 6);
        //Then
        Assert.Equal(0, result[0]);
        Assert.Equal(1, result[1]);
    }
}