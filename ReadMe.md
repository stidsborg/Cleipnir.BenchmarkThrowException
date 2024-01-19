```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
Intel Core i7-6700HQ CPU 2.60GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.405
  [Host]     : .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2


```
| Method                                | Mean     | Error    | StdDev   |
|-------------------------------------- |---------:|---------:|---------:|
| StackfullException                    | 13.18 μs | 0.110 μs | 0.103 μs |
| StacklessException                    | 12.86 μs | 0.209 μs | 0.196 μs |
| StackfullExceptionReturningStacktrace | 24.18 μs | 0.474 μs | 0.695 μs |
| StacklessExceptionReturningStacktrace | 12.62 μs | 0.240 μs | 0.267 μs |
