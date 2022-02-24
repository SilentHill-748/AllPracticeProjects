``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1165 (21H1/May2021Update)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100-preview.7.21379.14
  [Host]     : .NET 6.0.0 (6.0.21.37719), X64 RyuJIT
  DefaultJob : .NET 6.0.0 (6.0.21.37719), X64 RyuJIT


```
|               Method |      Mean |    Error |   StdDev |    Median | Rank |   Gen 0 |   Gen 1 | Allocated |
|--------------------- |----------:|---------:|---------:|----------:|-----:|--------:|--------:|----------:|
| DefaultListBenchmark |  36.59 μs | 0.848 μs | 2.475 μs |  35.91 μs |    1 | 62.4390 |       - |    128 KB |
|      MyListBenchmark | 135.84 μs | 2.685 μs | 2.511 μs | 135.90 μs |    2 | 79.8340 | 30.0293 |    313 KB |
