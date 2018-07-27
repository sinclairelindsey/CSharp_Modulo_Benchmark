``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.167 (1803/April2018Update/Redstone4)
Intel Xeon CPU E5-2620 v4 2.10GHz, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=2.1.302
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
|     Method | Length | Iterations |         Mean |       Error |       StdDev |       Median |
|----------- |------- |----------- |-------------:|------------:|-------------:|-------------:|
|     Modulo |     36 |      10000 | 35,107.51 ns | 695.4388 ns | 2,006.500 ns | 34,369.76 ns |
| Bruteforce |     36 |      10000 |  5,896.25 ns |  67.9892 ns |    56.774 ns |  5,880.45 ns |
| Enumerable |     36 |      10000 |     31.38 ns |   0.7299 ns |     2.152 ns |     30.52 ns |
