using Xunit;
using Xunit.Abstractions;
using Taz_LeetCode.Problems;

public class TestTwoSum
{

    private readonly ITestOutputHelper output;

    public TestTwoSum(ITestOutputHelper outputHelper)
    {
        output = outputHelper;
    }

    [Fact]
    public void Example1()
    {
        //Given
        TwoSum sut = new TwoSum();
        //When
        var result = sut.Solution(new int[] {2,7,11,15}, 9);
        //Then
        LogResults(result);
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
        LogResults(result);
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
        LogResults(result);
        Assert.Equal(0, result[0]);
        Assert.Equal(1, result[1]);
    }

    [Fact]
    public void DefaultTestCase()
    {
        //Given
        TwoSum sut = new TwoSum();
        //When
        var result = sut.Solution(new int[] {2,7,11,15}, 9);
        //Then
        LogResults(result);
        Assert.Equal(0, result[0]);
        Assert.Equal(1, result[1]);
    }

    private void LogResults(int[] results)
    {
        output.WriteLine($"Result[0] = {results[0]}, Results[1] = {results[1]}");
    }
}