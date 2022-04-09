using Lib;
using System.Threading.Tasks;
using Xunit;

namespace xUnitTests;
public class Tests
{
    [Fact]
    public async void AsyncVoidTest()
    {
        await SampleClass.Fail();
    }

    [Fact]
    public async Task AsyncTaskTest()
    {
        await SampleClass.Fail();
    }
}