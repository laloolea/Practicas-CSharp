``` ini

BenchmarkDotNet=v0.13.1, OS=macOS Monterey 12.2.1 (21D62) [Darwin 21.3.0]
Intel Core i7-6700HQ CPU 2.60GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.406
  [Host]     : .NET 5.0.15 (5.0.1522.11506), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 5.0.15 (5.0.1522.11506), X64 RyuJIT


```
|                 Method |      Mean |     Error |    StdDev |
|----------------------- |----------:|----------:|----------:|
| BenchmarkGenericEquals | 11.037 ms | 0.1223 ms | 0.1021 ms |
|    BenchMarkLongEquals |  8.004 ms | 0.0143 ms | 0.0134 ms |
