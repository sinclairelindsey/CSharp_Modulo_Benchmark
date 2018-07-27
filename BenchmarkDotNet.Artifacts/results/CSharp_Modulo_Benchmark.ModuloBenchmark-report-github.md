``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.167 (1803/April2018Update/Redstone4)
Intel Xeon CPU E5-2620 v4 2.10GHz, 1 CPU, 16 logical and 8 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3131.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3131.0


```
|     Method | Length | Iterations |         Mean |         Error |       StdDev |       Median |
|----------- |------- |----------- |-------------:|--------------:|-------------:|-------------:|
|     Modulo |     36 |      10000 | 33,981.07 ns | 1,650.1616 ns | 1,694.594 ns | 33,245.19 ns |
| Bruteforce |     36 |      10000 |  5,996.10 ns |   123.9321 ns |   226.617 ns |  5,884.37 ns |
| Enumerable |     36 |      10000 |     34.27 ns |     0.9983 ns |     1.554 ns |     33.67 ns |
