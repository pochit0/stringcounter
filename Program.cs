using NUnitLite;

namespace test4string
{
    class Program
    {
        static void Main(string[] args)
        {
            new AutoRun().Execute(new[]{"--noheader", "--noresult"});
        }
    }
}