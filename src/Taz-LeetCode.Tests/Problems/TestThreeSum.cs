using Xunit;
using Xunit.Abstractions;
using Taz_LeetCode.Problems;
using Taz_LeetCode.Tests.Exensions;
using System.Collections.Generic;

public class TestThreeSum
{
    ThreeSum sut = new ThreeSum();

    int[] _example1Input = {-1,0,1,2,-1,-4};
    List<List<int>> _example1Output = new List<List<int>>{
        new List<int>() { -1, -1, 2},
        new List<int>() { -1, 0, 1}
    };

    int[] _example2Input = {};
    List<List<int>> _example2Output = new List<List<int>>{};

    int[] _example3Input = {0};
    List<List<int>> _example3Output = new List<List<int>>{};

    int[] _test1Input = {4, 5, -9, 12, 59};

    List<List<int>> _test1Output = new List<List<int>>{
        new List<int>() {4, 5, -9},
    };

    [Fact]
    public void Example1()
    {
        Assert.Equal(_example1Output, sut.Solution(_example1Input));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(_example2Output, sut.Solution(_example2Input));
    }

    [Fact]
    public void Example3()
    {
        Assert.Equal(_example3Output, sut.Solution(_example3Input));
    }

    [Fact]
    public void Test1()
    {
        Assert.Equal(_test1Output, sut.Solution(_test1Input));
    }
}
