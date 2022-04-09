using Lib;
using NUnit.Framework;
using System.Threading.Tasks;

namespace NUnitTests;
public class Tests
{
    [Test]
    public async void AsyncVoidTest()
    {
        await SampleClass.Fail();
    }

    [Test]
    public async Task AsyncTaskTest()
    {
        await SampleClass.Fail();
    }
}