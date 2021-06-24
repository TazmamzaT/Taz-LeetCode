using Xunit;
using Xunit.Sdk;

namespace Taz_LeetCode.Tests.Exensions
{
    public static class AssertExtensions
    {
        public static void Equal(int[,] expected, int[] actual)
        {
            throw new EqualException(expected, actual);
        }
    }
}