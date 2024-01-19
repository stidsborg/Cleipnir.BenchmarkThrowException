using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Benchmark
{
    public class ExceptionTest
    {
        [Benchmark]
        public void StackfullException()
        {
            try
            {
                ThrowException();
            }
            catch (Exception e)
            {
                // ignored
            }
        } 

        [Benchmark]

        public void StacklessException()
        {
            try
            {
                ThrowOverridden();
            }
            catch (Exception e)
            {
                // ignored
            }
        }
        
        [Benchmark]
        public string StackfullExceptionReturningStacktrace()
        {
            try
            {
                ThrowException();
            }
            catch (Exception e)
            {
                return e.StackTrace ?? "";
            }

            return "";
        } 

        [Benchmark]

        public string StacklessExceptionReturningStacktrace()
        {
            try
            {
                ThrowOverridden();
            }
            catch (Exception e)
            {
                return e.StackTrace ?? "";
            }

            return "";
        }

        private void ThrowException()
        {
            throw new Exception("test");
        }

        private void ThrowOverridden()
        {
            throw new OverridenException();
        }
    }

    public class OverridenException : Exception
    {
        public override string? StackTrace { get; } = "";
    }
    
    public class Program
    {
        public static void Main()
        {
            BenchmarkRunner.Run<ExceptionTest>();
        }
    }
}