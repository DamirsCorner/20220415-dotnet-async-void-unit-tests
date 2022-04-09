namespace Lib;

public static class SampleClass
{
    public static Task Fail()
    {
        return Task.FromException(new NotImplementedException());
    }
}
