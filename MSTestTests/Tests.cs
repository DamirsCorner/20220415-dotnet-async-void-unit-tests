using Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace MSTestTests;
[TestClass]
public class Tests
{
    [TestMethod]
    public async void AsyncVoidTest()
    {
        await SampleClass.Fail();
    }

    [TestMethod]
    public async Task AsyncTaskTest()
    {
        await SampleClass.Fail();
    }
}