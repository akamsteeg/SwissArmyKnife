``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.192)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=2648435 Hz, Resolution=377.5815 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host] : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  Clr    : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2600.0
  Core   : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|          Method |  Job | Runtime |        Mean |     Error |    StdDev | Allocated |
|---------------- |----- |-------- |------------:|----------:|----------:|----------:|
| StringIsBetween |  Clr |     Clr | 166.5224 ns | 2.6292 ns | 2.3307 ns |       0 B |
|    IntIsBetween |  Clr |     Clr |   0.0037 ns | 0.0051 ns | 0.0045 ns |       0 B |
| DoubleIsBetween |  Clr |     Clr |   5.2946 ns | 0.0836 ns | 0.0782 ns |       0 B |
| StringIsBetween | Core |    Core |  76.5870 ns | 0.4298 ns | 0.3810 ns |       0 B |
|    IntIsBetween | Core |    Core |   0.0013 ns | 0.0035 ns | 0.0029 ns |       0 B |
| DoubleIsBetween | Core |    Core |   6.2857 ns | 0.0826 ns | 0.0733 ns |       0 B |
